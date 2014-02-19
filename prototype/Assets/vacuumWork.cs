using UnityEngine;
using System.Collections;

public class vacuumWork : MonoBehaviour {

	public GameObject bub1;
	float delay ;
	float  clickTime  ;
	bool touched;
	// Use this for initialization
	void Start () {
		delay = 2.30f;
		clickTime  = 0.0f;
		touched = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(touched){
			if(Time.time - clickTime <= delay){
				bub1.rigidbody2D.AddForce(Vector2.up *2f);
			}
		}
	}

	void OnMouseOver(){
		if (Input.GetMouseButtonDown (0)) {
			if (bub1.transform.position.x > this.gameObject.transform.position.x
			    && bub1.transform.position.x < this.gameObject.transform.position.x + this.gameObject.transform.GetComponent<BoxCollider2D>().size.y) {
				clickTime = Time.time;
				touched = true;
				Debug.Log("gat gat");
			}
		}
	}
}
