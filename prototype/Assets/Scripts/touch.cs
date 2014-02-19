using UnityEngine;
using System.Collections;

public class touch : MonoBehaviour {

	//public GameObject bub1;
	bool getNear;

	public int vUp;
	public int vRight;
	public float Direction;

	// Use this for initialization
	void Start () {
		getNear = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void isNear(bool flag)
	{
		getNear = flag;
	}

	void OnMouseOver(){
		if(Input.GetMouseButtonDown(0))
		{
			audio.Play();
			Debug.Log("out");
			if(getNear)
			{
				Debug.Log("in");
				fly();
			}

		}
	}


	void fly()
	{
		Debug.Log ("byzo22 tany");
		GameObject.FindWithTag("Bubble").rigidbody2D.velocity += new Vector2 (vRight, vUp) * Direction;
	}
}
