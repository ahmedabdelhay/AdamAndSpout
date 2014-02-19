using UnityEngine;
using System.Collections;

public class Pop : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver()
	{
		if(Input.GetMouseButtonDown(0))
		{
			audio.Play();
			Destroy(this.gameObject, 0.2f);
		}
		
	}
}
