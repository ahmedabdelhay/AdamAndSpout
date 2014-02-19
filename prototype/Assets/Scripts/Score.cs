using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	// Use this for initialization
	float lvl_Score = 0;
	void Start () {
	guiText.text = "Score : 0";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void AddScore()
	{
		lvl_Score++;
		guiText.text = "Score : " + lvl_Score;
	}
}
