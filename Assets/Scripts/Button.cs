using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace Assets.Scripts {
	public class Button : MonoBehaviour {

		public LevelManager levelManager;
		
		void Update () {
			if (CrossPlatformInputManager.GetButton("Fire1")) {
				if (transform.name != "MainMenu") {
					levelManager.LoadNextLevel();
				}
				else {
					levelManager.LoadLevel("00MainMenu");
				}
				
			}
		}
	}
}
