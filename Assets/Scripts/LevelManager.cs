﻿using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts {
	public class LevelManager : MonoBehaviour {
		
		public void LoadLevel(string name) {
			Debug.Log("New Level load: " + name);
			SceneManager.LoadScene(name);
		}

		public void QuitRequest() {
			Debug.Log("Quit requested");
			Application.Quit();
		}

		public void LoadNextLevel() {
			//SceneManager.LoadScene(Application.loadedLevel + 1);
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}
