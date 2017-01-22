using UnityEngine;

namespace Assets.Scripts {
	public class GameManager : MonoBehaviour {

		public enum GameState {
			Win,
			Lost
		}

		private GameObject _hades;
		private GameObject _player;
		private Health _hadesHealth;
		private Health _playerHealth;
		private LevelManager _levelManager;
		


		void Start () {
			_hades = GameObject.Find("Hades");
			_hadesHealth = _hades.GetComponent<Health>();
			_player = GameObject.Find("Player");
			_playerHealth = _player.GetComponent<Health>();
			_levelManager = FindObjectOfType<LevelManager>();
		}
	
		void Update () {
			if(_playerHealth.healtCondition == Health.HealtCondition.Death)
				Invoke("LoadLevel",2);
			if (_hadesHealth.healtCondition == Health.HealtCondition.Death)
				Invoke("LoadNextLevel", 2);

		}

		void LoadNextLevel() {
			_levelManager.LoadNextLevel();
		}

		void LoadLevel() {
			_levelManager.LoadLevel("05LostScreen");
		}
	}
}
