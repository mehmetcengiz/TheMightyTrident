using UnityEngine;

namespace Assets.Scripts {
	public class Player : MonoBehaviour {

		private Animator _playerAnimator;
		private Rigidbody _rigidbody;
		private Health myHealth;

		void Start() {
			_playerAnimator = GetComponent<Animator>();
			_rigidbody = GetComponent<Rigidbody>();
			myHealth = GetComponent<Health>();
		}

		void Update() {
			if(myHealth.healtCondition == Health.HealtCondition.Death)
				PerformDeath();
		}

		void OnTriggerEnter(Collider collider) {

			Enemy myEnemy = collider.transform.GetComponent<Enemy>();
			if (myEnemy) {
				myHealth.Damaged(myEnemy.enemyDamage);
			}
		}

		void PerformDeath() {
			_playerAnimator.SetBool("isDeath",true);
		}
	}
}
