using UnityEngine;

namespace Assets._Scripts {
	public class WaveSpawner : MonoBehaviour {

		public GameObject wave;
		public float _maxPower = 5f;

		private float _power;

		void Start() {
			_power = 0f;
		}

		void Update() {
			if (Input.GetKey(KeyCode.Space)) {
				_power += 0.1f;
				if (_power > _maxPower)
					_power = _maxPower;
			}else if (Input.GetKeyUp(KeyCode.Space)) {
				WaveAttack(_power);
				_power = 0f;
			}
		}

		void WaveAttack(float power) {
			GameObject newWaveGameObject = Instantiate(wave,transform.position,Quaternion.identity);
			newWaveGameObject.GetComponent<Wave>().SetPower(power);
		}
		

	}
}
