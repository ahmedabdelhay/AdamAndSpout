using UnityEngine;
using System.Collections;

public class bubMove : MonoBehaviour {
	float delay ;
	float  clickTime  ;
	bool bubClicked;
	//GameObject bub;
	public GameObject bub;
	public GameObject cubeObject;
	
	public GameObject Explosion_Prefab;
	// Use this for initialization
	void Start () {
		delay = 1.5f;
		clickTime  = 0.0f;
		bubClicked=false;
		
	}
	
	// Update is called once per frame
	void instiante ()
	{
		GameObject go = Instantiate(bub,transform.position,Quaternion.identity) as GameObject; 
		bub = go;     
		
		clickTime = Time.time;
		bubClicked=true;
		
		
	}
	void Update () {
		
		
		if(bubClicked)
		{
			if(bub)
			if(Time.time - clickTime <= delay){
				
				bub.rigidbody2D.AddForce(Vector2.up *3);
				// bub.rigidbody.AddForce(Vector3.up *2.0f);
				
				
				//        cubeObject.rigidbody2D.AddForce(Vector2.up *3);
				// rigidbody2D.AddForce( Vector2.right*2);
				
			}
			
			
			
			
			if(bub)
			if(Time.time - clickTime > delay){
				bub.rigidbody2D.AddForce( -Vector2.up*2);
				//bub.rigidbody.AddForce(Vector3.right *.75f);
				// bub.rigidbody.AddForce(-Vector3.up );
				bub. rigidbody2D.AddForce( Vector2.right*.7f);
				//bubClicked=false;
			}
			
		}
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Fan")
		{
			Destroy(this.gameObject);
			Instantiate(Explosion_Prefab, this.gameObject.transform.position, Quaternion.identity);
		}
		
	}
}




//void OnMouseOver()
