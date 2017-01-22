using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts {
	public class MusicManager : MonoBehaviour {

		public static MusicManager instance = null; // Setup Singleton Pattern So Only One Music Player Object Ever Instantiats
		public AudioClip startClip;
		public AudioClip gameClip;
		public AudioClip lostClip;
		public AudioClip winClip;
		private AudioSource _music;

		// Use this for initialization
		void Awake() {
			// If a MusicPlayer Already exists
			if (instance != null && instance != this) {
				Destroy(gameObject);
			}
			else {
				// Don't destroy this game object between scenes (i.e play music all the time between scenes)
				instance = this; // Claim the instance if it is null i.e. 1st time round
				GameObject.DontDestroyOnLoad(gameObject);
				_music = GetComponent<AudioSource>();
				//Add a DELEGATE to this to get notifications when a scene is load and thus play the appropriate level music
				SceneManager.sceneLoaded += OnSceneLoaded;
			}
		}

		//Load The Appropriate Music Depending On The Scene That Was Loaded
		void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode) {
			_music.Stop();
			if (SceneManager.GetActiveScene().buildIndex == 0) {
				_music.clip = startClip;
				_music.loop = true;
			}
			if (SceneManager.GetActiveScene().buildIndex == 1) {
				_music.clip = gameClip;
				_music.loop = true;
			}
			if (SceneManager.GetActiveScene().buildIndex == 4) {
				_music.clip = lostClip;
				_music.loop = false;
			}
			if (SceneManager.GetActiveScene().buildIndex == 5) {
				_music.clip = lostClip;
				_music.loop = false;
			}

			_music.Play();
		}
	}
}