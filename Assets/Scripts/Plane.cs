using UnityEngine;

namespace Assets.Scripts {
	public class Plane : MonoBehaviour {

		void OnTriggerEnter(Collider collider) {
			PerformPhysics();
			GetComponent<Enemy>().GotWaved(collider.GetComponent<Wave>().GetPower());
		}

		void PerformPhysics() {
			//Todo Perform ship physics.
			//Launch to air
			// Destroy objects if crash something.
		}
	}
}
