using UnityEngine;
using System.Collections;

public class PIB_BubMove : MonoBehaviour {
	
	public GameObject Explosion_Prefab;
	public GameObject puppyPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "HObject")
		{
			Destroy(this.gameObject);
			Instantiate(Explosion_Prefab, this.gameObject.transform.position, Quaternion.identity);
		}
		
	}
	
	void OnMouseOver()
    {
       	if (Input.GetMouseButtonDown(0))
       	{
       	    GameObject releasedPup = Instantiate(puppyPrefab, transform.position, Quaternion.identity) as GameObject;
       	    releasedPup.rigidbody2D.velocity = Vector2.up * 5;
			AudioSource.PlayClipAtPoint(audio.clip, transform.position);
           	Destroy(this.gameObject);
       	}
    }
}