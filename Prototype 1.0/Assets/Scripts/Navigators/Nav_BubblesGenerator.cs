using UnityEngine;
using System.Collections;

public class Nav_BubblesGenerator : MonoBehaviour {

	// Use this for initialization
	float timerInterval = 0.3f;
	float timer;
	
	public GameObject bubblePrefab;
	public float rndXMin, rndXMax, rndYMin, rndYMax;
	float rndX, rndY;

	void Start () 
	{
		timer = timerInterval;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButtonUp(0))
			audio.Stop();
	}

	//Generating the small bubbles and playing sounds
	void OnMouseOver()
	{
		if(Input.GetMouseButtonDown(0))
			audio.Play();
		/*else
			if(Input.GetMouseButtonUp(0))
				audio.Stop();*/
			

		if(Input.GetMouseButton(0))
		{
			timer -= Time.deltaTime;
			if(timer < 0)
			{
				timer = timerInterval;
				GameObject generatedBubble =  Instantiate(bubblePrefab, new Vector2(transform.position.x + 0.5f, transform.position.y), Quaternion.identity) as GameObject;

				float rotationAngle = Quaternion.Angle(generatedBubble.transform.rotation, transform.rotation);
				generatedBubble.transform.RotateAround(transform.position, Vector3.forward, rotationAngle);

				rndX = Random.Range(rndYMin, rndXMax);
				rndY = Random.Range(rndYMin, rndYMax);
				generatedBubble.rigidbody2D.velocity = new Vector2(2.5f + rndX, 1.5f + rndY);

				Destroy(generatedBubble, 5);
			}
		}
	}
}

