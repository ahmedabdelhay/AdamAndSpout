using UnityEngine;
using System.Collections;

public class Nav_FanAirRange : MonoBehaviour {

	public int vUp;
	public int vRight;
	public float Direction;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Bubble"){
			other.rigidbody2D.velocity += new Vector2 (vRight, vUp) * Direction;
			this.GetComponent<BoxCollider2D>().enabled = false;
		}
		
	}
}
