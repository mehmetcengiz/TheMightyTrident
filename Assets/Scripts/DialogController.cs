using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

namespace Assets.Scripts {
	public class DialogController : MonoBehaviour {


		public string[] whoIsTalking;

		public string[] hadesDialogs;
		public string[] poseidonDialogs;

		public Text hadesTextDisplay;
		public Text poseidonTextDisplay;

		private Animator _hadesAnimator;
		private Animator _poseidonAnimator;
		private int _talkingIndex;
		private int _poseidonTalkingIndex;
		private int _hadesTalkingIndex;

		


		void Start() {
			_hadesAnimator = GameObject.Find("Hades").GetComponent<Animator>();
			_poseidonAnimator = GameObject.Find("Poseidon").GetComponent<Animator>();
			_talkingIndex = 0;
			_poseidonTalkingIndex = 0;
			_hadesTalkingIndex = 0;
		}

		void Update() {
			if (CrossPlatformInputManager.GetButtonDown("Fire1")) {
				NextDialog();
			}
		}

		public void HadesTalking() {
			_hadesAnimator.SetBool("isHadesTalking", true);
			_poseidonAnimator.SetBool("isPoseidonTalking", false);
			poseidonTextDisplay.text = "";
			hadesTextDisplay.text = hadesDialogs[_hadesTalkingIndex];
			_hadesTalkingIndex++;
		}

		public void PoseidonTalking() {
			_hadesAnimator.SetBool("isHadesTalking", false);
			_poseidonAnimator.SetBool("isPoseidonTalking", true);
			hadesTextDisplay.text = "";
			poseidonTextDisplay.text = poseidonDialogs[_poseidonTalkingIndex]; 
			 _poseidonTalkingIndex++;

		}

		private void NextDialog() {
			if (_talkingIndex == whoIsTalking.Length) {
				FindObjectOfType<LevelManager>().LoadNextLevel();
			}else if (whoIsTalking[_talkingIndex] == "Hades" && _hadesTalkingIndex < hadesDialogs.Length) {
			print("Hades index =" + _hadesTalkingIndex + " " + hadesDialogs.Length);
				HadesTalking();
				_talkingIndex++;
			}else if (whoIsTalking[_talkingIndex] == "Poseidon" && _poseidonTalkingIndex < poseidonDialogs.Length)
			{
				print("Poseidon index =" + _poseidonTalkingIndex + " " + poseidonDialogs.Length);
				PoseidonTalking();
				_talkingIndex++;
			}


		}
	}
}
