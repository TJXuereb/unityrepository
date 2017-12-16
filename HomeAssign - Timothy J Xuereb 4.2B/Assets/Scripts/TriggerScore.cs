using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScore : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D hitInfo) //acknowledges that ball hit the score area
    {
        if (hitInfo.name == "Ball")
        {
            string wallName = transform.name;
            Scores.Score(wallName);
            hitInfo.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
