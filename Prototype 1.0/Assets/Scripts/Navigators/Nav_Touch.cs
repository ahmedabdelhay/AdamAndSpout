using UnityEngine;
using System.Collections;

public class Nav_Touch : MonoBehaviour {

	public GameObject fanRangePrefab;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}


	void OnMouseOver(){
		if (Input.GetMouseButtonDown (0)) 
		{
			GameObject.Find(this.name+"Range").GetComponent<BoxCollider2D>().enabled = true;
			audio.Play();
		}
	}
}
