using UnityEngine;

namespace Assets.Scripts {
	public class Hades : MonoBehaviour {

		public GameObject platformGameObject;

		private Health _hadesHealth;
		private bool _isDeath;
		private Rigidbody _rigidBody;
		private Vector3 _defaultPosition;

		void Start() {
			_hadesHealth = GetComponent<Health>();
			_rigidBody = GetComponent<Rigidbody>();
			
		}

		void Update () {

			_defaultPosition = platformGameObject.transform.position;
			_defaultPosition.y += 1.4f;
			if (_isDeath) {
				transform.rotation *= Quaternion.Euler(0, 0, 2);
			}
			else {
				transform.rotation =Quaternion.Euler(0,0,0);
				transform.localPosition = _defaultPosition;
			}
			
		}

		void OnTriggerEnter(Collider collider) {
			
			Enemy shipEnemy = collider.GetComponent<Enemy>();


			if (shipEnemy) {
				_hadesHealth.Damaged(shipEnemy.enemyDamage);
			}

			if (_hadesHealth.healtCondition == Health.HealtCondition.Death) {
				print("Hades death !!");
				PerformDeathAnimations();
			}
		}

		void PerformDeathAnimations() {
			_isDeath = true;
			print("perform animator");
			_rigidBody.useGravity = true;
		}
	}
}
