using UnityEngine;

namespace Assets.Scripts {
	public class EnemyMovement : MonoBehaviour {

		public float speed = 2f;

		private bool _isRotating;

		void Update () {
			transform.position += Vector3.left * Time.deltaTime * speed;
			if (!_isRotating)
				transform.rotation = Quaternion.Euler(0, 0, 0);
			else {
				transform.rotation *= Quaternion.Euler(0,0,-5);
			}
		}

		public void GetRotated() {
			_isRotating = true;
		}
	}
}
