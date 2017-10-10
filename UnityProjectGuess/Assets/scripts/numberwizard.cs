using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class numberwizard : MonoBehaviour {

    //declare 3 integer variables
	int max;
	int min;
	int guess;

    void NextGuess()
    {
        print("Is there number bigger or smaller than " + guess + " ?");
        print("Press UP if number is bigger");
        print("Press DOWN if number is smaller");
        print("Press ENTER if number is guessed");
    }

    void StartGame()
    {
		min = 1;
		max = 1001;
		guess = 500;
		//output to the console
		print("Welcome to the Number Wizard");
		//adding min and max to the String
		Debug.Log("Please choose a number from "+min+ " to "+max);
		NextGuess();
    }

    // Use this for initialization
    void Start () {

		StartGame();


	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Debug.Log ("UP Pressed");
			min = guess;
			guess = (max + min) / 2;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("DOWN Pressed");
			max = guess;
			guess = (max + min) / 2;
			NextGuess ();
        
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			Debug.Log ("ENTER Pressed");
			Debug.Log ("NUMBER GUESSED. Awesome!");
			print ("(P)lay Again or (Q)uit");

			if (Input.GetKeyDown (KeyCode.Q)) {
				UnityEditor.EditorApplication.isPlaying = false;
			} 
			else 
				if (Input.GetKeyDown (KeyCode.P)) 
				{
					StartGame ();
				}

		}
    }
}
