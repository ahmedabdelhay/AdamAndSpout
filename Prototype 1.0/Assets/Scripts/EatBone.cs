using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class EatBone : MonoBehaviour {

	//public AudioClip boneSound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Bubble")
		{
			AudioSource.PlayClipAtPoint(audio.clip, transform.position);
			Destroy(this.gameObject);
		}
	}
}
