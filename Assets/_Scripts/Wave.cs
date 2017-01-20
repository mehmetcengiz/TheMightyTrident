using UnityEngine;

namespace Assets._Scripts {
	public class Wave : MonoBehaviour {

		public float scaleByPower = 0.5f;

		private float _wavePower;
	

		// Update is called once per frame
		void Update () {
			transform.position += Vector3.right * _wavePower * Time.deltaTime;
			print("New wave power " + _wavePower);
			transform.localScale = new Vector3(1 * _wavePower * scaleByPower,
				1 * _wavePower * scaleByPower, 
				1 * _wavePower *scaleByPower);
		}

		public void SetPower(float power) {
			_wavePower = power;
		}
	}
}
