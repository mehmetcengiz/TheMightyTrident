using UnityEngine;

namespace Assets.Scripts {
	public class SpawnPoints : MonoBehaviour {

		public GameObject enemy;
		public float minSpawnTime = 4f; 
		public float maxSpawnTime = 10f;

		private float _lastTimeSpawned = 0f;
		private float _randomSpawnSecond;

		void Start() {
			_randomSpawnSecond = Random.Range(0, maxSpawnTime);
		}

		void Update () {
			if (Time.timeSinceLevelLoad - _lastTimeSpawned > _randomSpawnSecond) {
				_randomSpawnSecond= Random.Range(minSpawnTime, maxSpawnTime);
				_lastTimeSpawned = Time.timeSinceLevelLoad;
				Instantiate(enemy, transform.position, Quaternion.identity);
			}
		}
	}
}
