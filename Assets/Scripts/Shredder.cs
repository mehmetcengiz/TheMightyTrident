using UnityEngine;

namespace Assets.Scripts {
	public class Shredder : MonoBehaviour {

		void OnTriggerEnter(Collider collider) {
			Destroy(collider.transform.gameObject);
		}
	}
}
