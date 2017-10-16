using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {

	public AudioClip shew;
	public AudioSource Knight;
	public GameObject Bishop; 

		void Start () {

	//audioSource = GetComponent<AudioSource>();

	}

	
	// Update is called once per frame
	// Those are the code to make the player move
	// Source: http://gigi.nullneuron.net/gigilabs/unity3d-moving-an-object-with-keyboard-input/
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
		Vector3 position = this.transform.position;
		position.x--;
		this.transform.position = position;
		Knight.PlayOneShot(shew, 0.9F);
	}

		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
		Vector3 position = this.transform.position;
		position.x++;
		this.transform.position = position;
		Knight.PlayOneShot(shew, 0.9F);
	}

		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
		Vector3 position = this.transform.position;
		position.z++;
		this.transform.position = position;
		Knight.PlayOneShot(shew, 0.9F);
	}

		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
		Vector3 position = this.transform.position;
		position.z--;
		this.transform.position = position;
		Knight.PlayOneShot(shew, 0.9F);
	}
}

	void OnTriggerEnter(Collider other) {
		if (Bishop.gameObject.CompareTag("bishop"))
		{ 
		Bishop.gameObject.SetActive(false);
		}

	}


}