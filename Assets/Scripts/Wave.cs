using UnityEngine;

namespace Assets.Scripts {
	public class Wave : MonoBehaviour {

		public float scaleByPower = 0.5f;

		private float _wavePower;
		private float _speedByPower;
	
		void Update () {
			transform.position += Vector3.right * _speedByPower * Time.deltaTime;
			transform.localScale = new Vector3(1 * _wavePower * scaleByPower,
				1 * _wavePower * scaleByPower, 
				1 * _wavePower *scaleByPower);
		}

		public void SetPower(float power) {
			_wavePower = power;
			_speedByPower = _wavePower < 3 ? 3f : _wavePower;
		}

		void OnTriggerEnter(Collider collider) {

			if (collider.transform.tag == "Crashable") {
				Invoke("LaunchDestroy", 0.2f);
			}
		}

		void LaunchDestroy() {
			Destroy(transform.gameObject);
		}

		public float GetPower() {
			return _wavePower;
		}
	}
}
