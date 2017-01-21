using UnityEngine;

namespace Assets.Scripts {
	public class Health : MonoBehaviour {


		public enum HealtCondition {
			Alive,
			Death,
		}
		
		public int healt;
		public HealtCondition healtCondition;

		void Start() {
			healtCondition = HealtCondition.Alive;
		}

		public void Damaged(float damage) {
			healt -= (int) damage;
			if (healt <= 0) {
				healtCondition = HealtCondition.Death;
				Destroy(transform.gameObject); // TODO later change this with animation.
			}
		}
	}
}
