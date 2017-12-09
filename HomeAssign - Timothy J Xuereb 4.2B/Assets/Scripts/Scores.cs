using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scores : MonoBehaviour {

    public static int Player1 = 0;
    public static int Player2 = 0;

    public GUISkin layout;

    GameObject theBall;

    // Use this for initialization
    void Start () {
        theBall = GameObject.FindGameObjectWithTag("Ball");
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
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + Player1);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + Player2);

        if (Player1 == 3)
        {
            //levelmanager here (go to next level)
        }
        else if (Player2 == 3)
        {
            //levelmanager here (go to next level)
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
