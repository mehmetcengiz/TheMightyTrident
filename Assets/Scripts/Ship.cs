using UnityEngine;

namespace Assets.Scripts {
	public class Ship : MonoBehaviour {

		public AudioClip shipDestroySound;
		public AudioClip shipOnJumpSound;


		private Rigidbody _rigidbody;
		private float _speedOfShip = 1f;
		private Animator _animator;
		

		private AudioSource _audioSource;

		void Start() {
			_rigidbody = GetComponent<Rigidbody>();
			_animator = GetComponent<Animator>();
			_audioSource = GetComponent<AudioSource>();

		}

		void OnTriggerEnter(Collider collider) {
			Wave wave = collider.GetComponent<Wave>();

			if (wave) {
				_speedOfShip = wave.GetPower();
				GetComponent<Enemy>().GotWaved(_speedOfShip);
				if (GetComponent<Health>().healtCondition == Health.HealtCondition.Death) {
					if (_speedOfShip > 3) {
						PerformPowerfulPhysics();
					}
					else {
						PerformLowerPhysics();
					}
					
				}
			}
		}

		void OnCollisionEnter(Collision collision) {
			if (collision.transform.name == "Platform") {
				_animator.SetTrigger("deathTrigger");
			}
		}

		void PerformLowerPhysics() {
			_rigidbody.useGravity = true;
			_rigidbody.velocity = Vector3.up;
		}

		void PerformPowerfulPhysics() {
			_audioSource.clip = shipOnJumpSound;
			if (!_audioSource.isPlaying) {
				_audioSource.Play();
			}
			_rigidbody.useGravity = true;
			_rigidbody.velocity = Vector3.up * _speedOfShip * 2.5f;
			GetComponent<EnemyMovement>().GetRotated();
		}
	}
}
