using UnityEngine;

namespace Assets.Scripts {
	public class Player : MonoBehaviour {

		void OnTriggerEnter(Collider collider) {

			Enemy myEnemy = collider.transform.GetComponent<Enemy>();
			Health myHealth = GetComponent<Health>();

			if (myEnemy) {
				if (myHealth.healtCondition == Health.HealtCondition.Death) {
					print("Death");
					return;
				}
				myHealth.Damaged(myEnemy.enemyDamage);
			}
		}
	}
}
