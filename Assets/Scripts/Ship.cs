using UnityEngine;

namespace Assets.Scripts {
	public class Ship : MonoBehaviour {

		void OnTriggerEnter(Collider collider) {
			PerformPhysics();
            print(collider.transform.name);
			GetComponent<Enemy>().GotWaved(collider.GetComponent<Wave>().GetPower());
		}

		void PerformPhysics() {
			//Todo Perform ship physics.
		}
	}
}
