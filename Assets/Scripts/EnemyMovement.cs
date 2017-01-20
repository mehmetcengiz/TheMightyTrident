using UnityEngine;

namespace Assets.Scripts {
	public class EnemyMovement : MonoBehaviour {

		public float speed = 2f;

		void Update () {
			transform.position += Vector3.left * Time.deltaTime * speed;
		}
	}
}
