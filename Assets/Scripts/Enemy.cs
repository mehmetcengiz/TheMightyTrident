using UnityEngine;

namespace Assets.Scripts {
	public class Enemy : MonoBehaviour  {

		public void GotWaved(float power) {
			transform.GetComponent<Health>().Damaged(power);
		}


	}
}
