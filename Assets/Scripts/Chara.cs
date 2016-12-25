using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara : MonoBehaviour {

	Rigidbody2D rigidBody;

	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
	}
	
	void Update () {
		
	}

	public void move(float dx){
		Vector2 vec = rigidBody.velocity;
		vec.x = dx;
		rigidBody.velocity = vec;
	}
}
