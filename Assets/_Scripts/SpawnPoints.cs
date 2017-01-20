using UnityEngine;


namespace Assets {
	public class SpawnPoints : MonoBehaviour {

		public GameObject enemy;
		public GameObject parent;
		public float minSpawnTime = 4f; 
		public float maxSpawnTime = 10f;
		public float minSpawnRange = 0.5f;
		public float maxSpawnRange = 2f;

		private float _lastTimeSpawned = 0f;
		private float _randomSpawnSecond;

		void Start() {
			_randomSpawnSecond = Random.Range(0, maxSpawnTime);
		}

		void Update () {

			if (Time.timeSinceLevelLoad - _lastTimeSpawned > _randomSpawnSecond) {
				_randomSpawnSecond= Random.Range(minSpawnTime, maxSpawnTime);
				_lastTimeSpawned = Time.timeSinceLevelLoad;
				SpawnObject();
			}
		}

		void SpawnObject() {
			float randomRange = Random.Range(minSpawnRange, maxSpawnRange);
			Instantiate(enemy, new Vector3(transform.position.x,transform.position.y + randomRange, 0), Quaternion.identity);
		}

	}
}
