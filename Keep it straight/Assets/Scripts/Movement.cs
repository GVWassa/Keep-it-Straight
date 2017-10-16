using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

public float radius = 9.0f;
public float speed = 0.10f;

//The point we are going around in circles
private Vector2 basestartpoint;

//Destination of our current move
private Vector2 destination;

//start of our current move
private Vector2 start;

//current move's progress
private float progress = 0.0f;

	// Use this for initialization
	void Start () {
		start = transform.localPosition;
		basestartpoint = transform.localPosition;
		progress = 0.0f;

		PickNewRandomDestination ();
	}
	
	// Update is called once per frame
	void Update () {

			//bool reached = false;

			//update our progress to our destination
			progress += speed * Time.deltaTime;

			//Check for the case when we overshoot or reach our destination
			if (progress >=0.70f)
			{ progress = 0.70f;
				//reached = true;
			}

			//Update out position based on our start position, destination and progress
			transform.localPosition = (destination*progress)+ start*(1-progress);
		
	}

	// To make the pieces move inside the void
	void PickNewRandomDestination () {
	destination = Random.insideUnitCircle*radius+basestartpoint;

		
	}
}

// source for mvt: https://stackoverflow.com/questions/38296456/random-movement-within-a-circle