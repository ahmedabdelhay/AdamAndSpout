using UnityEngine;
using System.Collections;

public class Particle_Gen : MonoBehaviour {

	// Use this for initialization
	float timer;
	public float magicnum;
	public GameObject bubble_Prefab;
	void Start () 
	{
		timer = magicnum;
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		if(timer < 0)
		{
			timer = magicnum;
			//genBubbles();
		}
	}

	void genBubbles()
	{
		float RndX = Random.Range(0.8f, 2.5f);
		float RndY = Random.Range(0.5f, 1.5f);
		GameObject newBuble =  Instantiate(bubble_Prefab, transform.position, Quaternion.identity) as GameObject;
		newBuble.rigidbody2D.velocity = new Vector2(2.5f + RndX, 1.5f + RndY);
		Destroy(newBuble, 5);
	}
}
