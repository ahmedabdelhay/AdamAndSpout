using UnityEngine;
using System.Collections;

public class PlayerOnBubbles : MonoBehaviour {

	// Use this for initialization
	float timer;
	public float magicnum;
	GameObject myGen;
	void Start () 
	{
		timer = magicnum;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver()
	{
		if(Input.GetMouseButtonDown(0))
				audio.Play();	
		else if(Input.GetMouseButtonUp(0))
				audio.Stop();
			

		if(Input.GetMouseButton(0))
		{
			timer -= Time.deltaTime;
			if(timer < 0)
			{
				timer = magicnum;
				gameObject.GetComponentInChildren<Particle_Gen>().SendMessage("genBubbles");
			}
		}
	}
}

