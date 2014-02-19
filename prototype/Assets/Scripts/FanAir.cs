using UnityEngine;
using System.Collections;

public class FanAir : MonoBehaviour {
	

	bool getNear;

	// Use this for initialization
	void Start () {
		getNear = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Bubble"){
			Debug.Log ("geh 2oddamo");
			getNear = true;
			this.transform.parent.GetComponent<touch>().SendMessage("isNear", getNear);
		}
		
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "Bubble"){
			Debug.Log ("5arag");
			getNear = false;
			this.transform.parent.GetComponent<touch>().SendMessage("isNear", getNear);
		}
	}

}
