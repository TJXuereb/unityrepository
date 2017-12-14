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
        theBall = GameObject.Find("Ball");
        lm = GameObject.FindObjectOfType<LevelManager>();
    }

    public static void Score(string wallID) //detects when ball hits a score point.
    {
        if (wallID == "RightWall")
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

        if (Player1 == 3)
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
