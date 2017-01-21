using UnityEngine;

namespace Assets.Scripts {
	public class Submarine : MonoBehaviour {

		void OnTriggerEnter(Collider collider)
		{
			PerformPhysics();
			Wave wave = collider.GetComponent<Wave>();
			if (wave)
				GetComponent<Enemy>().GotWaved(wave.GetPower());
		}

		void PerformPhysics()
		{
			//Todo Perform ship physics.
			//Launch to air
			// Destroy objects if crash something.
		}
	}
}
