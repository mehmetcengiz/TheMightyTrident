using UnityEngine;

namespace Assets.Scripts {
	public class Player : MonoBehaviour {

		void OnTriggerEnter(Collider collider) {
			if (collider.transform.GetComponent<Enemy>()) {
				//TODO death animations
				print("Death");
			}
		}
	}
}
