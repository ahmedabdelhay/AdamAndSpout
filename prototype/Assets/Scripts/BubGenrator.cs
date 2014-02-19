using UnityEngine;
using System.Collections;

public class BubGenrator : MonoBehaviour
{

    // Use this for initialization
    bool Generated = false;
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {

        //      GameObject go = Instantiate("bub1") as GameObject;
      /* if (Input.GetMouseButtonDown(0))
        {
            GameObject.FindWithTag("bubObject").GetComponent<bubMove>().SendMessage("instiante");
        }*/
        
    }
    void OnMouseOver()
    {
        
        if (Input.GetMouseButtonDown(0) && !Generated)
        {
            Debug.Log("Input" + Input.mousePosition.x);
            GameObject.FindWithTag("bubObject").GetComponent<bubMove>().SendMessage("instiante");
            Generated = true;
        }
    }

}