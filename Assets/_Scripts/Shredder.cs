using UnityEngine;

namespace Assets._Scripts {
	public class Shredder : MonoBehaviour {

		void OnTriggerEnter(Collider collider) {
			Destroy(collider.transform.gameObject);
		}
	}
}
