using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class numberwizard : MonoBehaviour {

    //declare 3 integer variables
    int max = 1001;
	int min = 0;
	int guess;
    int maxNumberOfTries = 10;

    public Text guessText;

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = (max + min) / 2;

        guessText.text = guess.ToString();

        maxNumberOfTries--;
        if (maxNumberOfTries == 0)
        {
            SceneManager.LoadScene("Win");
            min = 1;
            max = 1001;
            guess = Random.Range(min, max);
        }
    }

    // Use this for initialization
    void Start () {

        guess = Random.Range(min, max);
        guessText.text = guess.ToString();

	}
	
	// Update is called once per frame
	void Update () {

    }
}
