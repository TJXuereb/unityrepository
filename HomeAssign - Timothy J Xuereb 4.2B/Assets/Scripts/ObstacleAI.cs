using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAI : MonoBehaviour {

    public Transform AI;
    public float AIspeed;

    // Use this for initialization
    void Start () {
        AI = GameObject.Find("Ball").transform;
    }
	
	// Update is called once per frame
	void Update () {
        float step = AIspeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, AI.position, step); //follows the ball at the set speed given through Unity interface.
    }
}
