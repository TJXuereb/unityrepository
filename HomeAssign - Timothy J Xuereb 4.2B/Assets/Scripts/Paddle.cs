using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    private Ball myBall;

	// Use this for initialization
	void Start () {

        myBall = GameObject.FindObjectOfType<Ball>();
		
	}
	
	// Update is called once per frame
	void Update () {

        //save the mouse position in Unity units 
        float mousePosInUnits = (Input.mousePosition.y / Screen.height * 10f) - 5f;

        
        //this.transform.position.y: keeps the starting y-value
        Vector3 paddlePosition = new Vector3(this.transform.position.x, mousePosInUnits, 0f);



        //make the paddle move with the mouse
        paddlePosition.y = Mathf.Clamp(mousePosInUnits, -4f, 4f);

        

        //set the position of the paddle to paddlePosition
        this.transform.position = paddlePosition;

		
	}
}
