using UnityEngine;

namespace Assets._Scripts {
	public class EnemyController : MonoBehaviour {

		public float speed = 2f;

		void Update () {
			transform.position += Vector3.left * Time.deltaTime * speed;
		}
	}
}
