﻿using UnityEngine;
using System.Collections;

public class Nav_BubblesTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Bubble")
		other.rigidbody2D.velocity = rigidbody2D.velocity;
	}
}
