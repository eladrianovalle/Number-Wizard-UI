using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	int min;
	int max;
	int guess;

	[SerializeField]
	public static int maxGuessesAllowed = 5;

	public Text guessText;

	void Start() {
		StartGame ();
	}

	void StartGame(){
		min = 1;
		max = 1000;
		NextGuess ();
	}

	public void GuessHigher() {
		min = guess;
		NextGuess ();
	}

	public void GuessLower() {
		max = guess;
		NextGuess ();
	}

	void NextGuess() {
		maxGuessesAllowed--;
		if (maxGuessesAllowed < 0) {
			LevelManager.LoadWin();
		}
		guess = Random.Range (min, max+1);
		guessText.text = guess.ToString ();
	}
}
