using UnityEngine;

namespace Assets.Scripts {
	public class Enemy : MonoBehaviour {

		public float enemyDamage;

		public void GotWaved(float power) {
			transform.GetComponent<Health>().Damaged(power *2.5f);
		}
		
	}
}
