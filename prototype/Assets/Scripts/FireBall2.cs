using UnityEngine;
using System.Collections;

public class FireBall2 : MonoBehaviour {
public GameObject dog;

	// Use this for initialization
	void Start () {
        Debug.Log("lakjcnsdkjn");
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("lakjcnsdkjn");
	}
    void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {

            GameObject go = Instantiate(dog, transform.position, Quaternion.identity) as GameObject;
            go.rigidbody2D.AddForce(-Vector2.up * 8);
            audio.Play();
            Destroy(this.gameObject, 0.2f);
        }
    }
}
