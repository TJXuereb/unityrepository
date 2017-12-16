using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scores : MonoBehaviour {

    public static int Player1 = 0;
    public static int Player2 = 0;

    private LevelManager lm;

    public GUISkin layout;

    private GUIStyle guiStyle = new GUIStyle();

    GameObject theBall;

    // Use this for initialization
    void Start () {
        Player1 = 0; //starts the level with 0 scores
        Player2 = 0;
        theBall = GameObject.Find("Ball");
        lm = GameObject.FindObjectOfType<LevelManager>();
    }

    public static void Score(string wallID) //detects when ball hits a score point.
    {
        if (wallID == "RightWall") //if ball hits right wall, player1 gets 1 point, if not right wall means left wall was triggered so player2 gets 1 point.
        {
            Player1++;
        }
        else
        {
            Player2++;
        }
    }

    void OnGUI()
    {
        GUI.skin = layout;
        guiStyle.fontSize = 24; //increases Score number size
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + Player1, guiStyle);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + Player2, guiStyle); //labels for Score numbers

        if (Player1 == 3) //when a player gets 3 points, advances to next level
        {
            lm.LoadNextLevel();
        }
        else if (Player2 == 3)
        {
            lm.LoadNextLevel();
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
