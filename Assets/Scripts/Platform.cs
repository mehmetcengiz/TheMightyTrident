using UnityEngine;

namespace Assets.Scripts {
	public class Platform : MonoBehaviour {

		public float speed = 5f;

		private bool _toggleMovement;
		private float _cameraEdgeLeft = -8f;
		private float _cameraEdgeRight = 8f;

		void Update() {
			ToggleMovement();
		}

		private void ToggleMovement() {
			if (_toggleMovement)
				transform.position += Vector3.left * Time.deltaTime * speed;
			else
				transform.position += Vector3.right * Time.deltaTime * speed;

			if (transform.position.x < _cameraEdgeLeft)
				_toggleMovement = false;

			if (transform.position.x > _cameraEdgeRight)
				_toggleMovement = true;
		}

		void OnTriggerEnter(Collider collider) {
			PerformPhysics();

			Wave wave = collider.GetComponent<Wave>();
			if (wave)
				GetComponent<Enemy>().GotWaved(wave.GetPower());
		}

		void PerformPhysics() {
			//Todo Perform ship physics.
			//Launch to air
			// Destroy objects if crash something.
		}
	}
}
