using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace Assets.Scripts {
	public class WaveSpawner : MonoBehaviour {

		public GameObject wave;
		public float _maxPower = 5f;

		private float _power;
		private ShootPoint _shootingPoint;
		private Animator _animator;

		void Start() {
			_power = 0f;
			_shootingPoint = GetComponentInChildren<ShootPoint>();
			_animator = GetComponent<Animator>();
		}

		void Update() {
			if (CrossPlatformInputManager.GetButton("Fire1")) {
				_power += 0.1f;
				if (_power > _maxPower)
					_power = _maxPower;
			}else if (CrossPlatformInputManager.GetButtonUp("Fire1")) {
				StartAttack();
			}
		}

		void StartAttack() {
			_animator.SetTrigger("attackTrigger");
		}

		public void WaveAttack()
		{
			var shootingPoint = new Vector3(0,0,0);
			shootingPoint = _shootingPoint.transform.position;
			shootingPoint += new Vector3(0, _power / 13, 0);
			GameObject newWaveGameObject = Instantiate(wave,shootingPoint,Quaternion.identity);
			newWaveGameObject.GetComponent<Wave>().SetPower(_power);
			_power = 0f;
		}
		

	}
}
