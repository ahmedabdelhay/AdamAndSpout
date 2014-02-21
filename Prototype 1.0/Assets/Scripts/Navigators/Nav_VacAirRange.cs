using UnityEngine;
using System.Collections;

public class Nav_VacAirRange : MonoBehaviour {

	public int vUp;
	public int vRight;
	public float Direction;

	Collider2D PIB;
	bool puppyInRange = false;

	float timerInterval;
    float  timer;

	// Use this for initialization
	void Start () {
		timerInterval = 0.1f;
		timer = timerInterval;
	}
	
	// Update is called once per frame
	void Update () {
		if(puppyInRange)
		{
			timer -= Time.deltaTime;
            if(timer < 0)
            {
				PIB.rigidbody2D.velocity += new Vector2 (vRight, vUp) * Direction;
                timer = timerInterval;
			}
		}

		if(!this.GetComponent<BoxCollider2D>().enabled)
			puppyInRange = false;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Bubble"){
			PIB = other;
			puppyInRange = true;
		}
		
	}

	void OnTriggerExit2D(Collider2D other)
	{
		puppyInRange = false;	
	}
}
