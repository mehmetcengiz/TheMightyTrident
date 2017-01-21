using UnityEngine;

namespace Assets.Scripts {
	public class Enemy : MonoBehaviour  {
		public void GotWaved(float power) {
			print(power);
			transform.GetComponent<Health>().Damaged(power *2.5f);
		}
		
	}
}
