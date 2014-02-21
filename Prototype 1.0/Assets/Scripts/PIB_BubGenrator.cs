using UnityEngine;
using System.Collections;

public class PIB_BubGenrator : MonoBehaviour
{
    GameObject PIB;
    public GameObject pibPrefab;
    public GameObject Explosion_Prefab;
    bool Generated = false;

    float timerInterval;
    float  timer;
    int upCount, upNum;

    public float initVerticalVel, initHorizontalVel;
    Vector2 initVelocity;
    
    // Use this for initialization
    void Start()
    {
        timerInterval = 0.1f;
        timer  = timerInterval;
        upCount = 0;
        upNum = 5;
        initVelocity = (Vector2.up * initVerticalVel) + (Vector2.right * initHorizontalVel);
    }

    // Update is called once per frame
    void Update()
    {
        if(Generated && upCount < upNum)
        {
            timer -= Time.deltaTime;
            if(timer < 0)
            {
                PIB.rigidbody2D.velocity += initVelocity;
                timer = timerInterval;
                upCount ++;
            }
        }
    }

    void OnMouseOver()
    {
        //Instantiating Puppy In Bubble
        if (Input.GetMouseButtonDown(0) && !Generated)
        {
            PIB = Instantiate(pibPrefab, new Vector2(transform.position.x - 0.5f, transform.position.y + 1.5f), Quaternion.identity) as GameObject;
            PIB.rigidbody2D.velocity = initVelocity;
            Generated = true;
        }
    }

}