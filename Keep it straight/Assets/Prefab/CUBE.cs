using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUBE : MonoBehaviour {

	public float ChangeSpeed;

	// Use this for initialization
	void Start () {
		ChangeSpeed = 10;
		InvokeRepeating("SetRandomPos", 0,1);

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = new Vector3(Random.Range(-9f,9f),
		0, Random.Range(-9f,9f));
		transform.position = temp;
	
	}
}
//http://answers.unity3d.com/questions/1166302/move-gameobject-randomly.html
