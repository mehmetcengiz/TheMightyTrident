using UnityEngine;

namespace Assets.Scripts {
	public class Player : MonoBehaviour {

		private Animator _playerAnimator;
		private Rigidbody _rigidbody;

		void Start() {
			_playerAnimator = GetComponent<Animator>();
			_rigidbody = GetComponent<Rigidbody>();
		}

		void OnTriggerEnter(Collider collider) {

			Enemy myEnemy = collider.transform.GetComponent<Enemy>();
			Health myHealth = GetComponent<Health>();

			if (myEnemy) {
				if (myHealth.healtCondition == Health.HealtCondition.Death) {
					PerformDeath();
					return;
				}
				myHealth.Damaged(myEnemy.enemyDamage);
			}
		}

		void PerformDeath() {
			_playerAnimator.SetBool("isDeath",true);
		}
	}
}
