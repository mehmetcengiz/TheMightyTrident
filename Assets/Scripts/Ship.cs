using UnityEngine;

namespace Assets.Scripts {
	public class Ship : MonoBehaviour {

		private Rigidbody _rigidbody;
		private float _speedOfShip = 1f;

		void Start() {
			_rigidbody = GetComponent<Rigidbody>();

		}

		void OnTriggerEnter(Collider collider) {
			
			Wave wave = collider.GetComponent<Wave>();
			if (wave) {
				_speedOfShip = wave.GetPower();
				GetComponent<Enemy>().GotWaved(_speedOfShip);
				PerformPhysics();
			}

		}

		void PerformPhysics() {
			//Todo Perform ship physics.
			_rigidbody.useGravity = true; 
			_rigidbody.velocity = Vector3.up * _speedOfShip * 2.5f ;
			print("Physics perform");
		}
	}
}
