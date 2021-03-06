using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
    public int maxGuessesAllowed = 10;
    public Text text;

	void Start () {	
		StartGame();	
	}
	
    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }
    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }
    void StartGame(){
		max = 1000;
		min = 1;
        NextGuess();	
	}
	
	void NextGuess(){
        guess = Random.Range(min, max+1);
        text.text = guess.ToString();
        maxGuessesAllowed = maxGuessesAllowed - 1;
        if (maxGuessesAllowed <= 0)
        {
            SceneManager.LoadScene("Lose");
        }	
	}




}
