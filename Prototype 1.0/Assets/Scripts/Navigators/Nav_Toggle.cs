using UnityEngine;
using System.Collections;

public class Nav_Toggle : MonoBehaviour {

	public GameObject vacuumRangePrefab;
	AudioSource onSound, offSound;
	bool vToggle = false;

	// Use this for initialization
	void Start () 
	{
		onSound = GetComponents<AudioSource>()[0];
		offSound = GetComponents<AudioSource>()[1];
	}
	
	// Update is called once per frame
	void Update () {

	}


	void OnMouseOver(){
		if (Input.GetMouseButtonDown (0)) 
		{
			GameObject vRange = GameObject.Find(this.name+"Range");
			if(!vToggle)
			{
				offSound.Stop();
				vRange.GetComponent<BoxCollider2D>().enabled = true;
				onSound.Play();
			}
			else
			{
				onSound.Stop();
				vRange.GetComponent<BoxCollider2D>().enabled = false;
				offSound.Play();
			}
			vToggle = !vToggle;
		}
	}
}
