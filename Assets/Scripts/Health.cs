using UnityEngine;

namespace Assets.Scripts {
	public class Health : MonoBehaviour {


		public enum HealtCondition {
			Alive,
			Death,
		}
		
		public int healt;
		public HealtCondition _healtCondition;

		void Start() {
			_healtCondition = HealtCondition.Alive;
		}

		public void Damaged(float damage) {
			healt -= (int) damage;
			if (healt <= 0) {
				_healtCondition = HealtCondition.Death;
			}
		}
	}
}
