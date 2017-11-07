using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //save the position in Unity units of the mouse
        //Depending on the number of units on screen
        float mousePosinUnits = (Input.mousePosition.x / Screen.width * 13f) - 6.5f;

        //creates a Vector3 which saves a coordinate
        //in (x,y,z)
        //this.transform.y: keeps the starting y-value
        Vector3 paddlePosition = new Vector3(2f, this.transform.position.y, 0f);

        //make the paddle move with the mouse
        paddlePosition.x = mousePosinUnits;

        //sets the position of the paddle (this) to paddleposition
        this.transform.position = paddlePosition;


	}
}
