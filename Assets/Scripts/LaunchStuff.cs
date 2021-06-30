using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchStuff : MonoBehaviour
{
    // Wat do we launch??
    // Put Reference here
	public GameObject stuff;

    public GameObject[] themThings;

    public int ranNumber;

    Rigidbody2D blah;

    Vector2 wat;


    GameObject spawnedBit;

    float myTimer = 0;
    float endTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        //spawnedBit = Instantiate(stuff);

        stuff.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 5, ForceMode2D.Impulse);


    }

    // Update is called once per frame
    void Update()
    {
        //for(int i = 0; i < themThings.Length; i++)
        //{
        //    if (themThings[i] != null) themThings[i].transform.Translate(0, 0.1f, 0);
        //}

        if(myTimer > endTime)
        {
            // My delayed code
            Debug.LogWarning("Uh Oh! No Timed code here!");
            myTimer = 0;
        }
        else
        {
            myTimer += Time.deltaTime;
        }
        
    }

    public GameObject LaunchSomething()
    {
        // Here We Launch
        Debug.Log("Yup, You done Launched!");
        return stuff;
    }

    public int AddOne(int fromWhat)
    {
        int mReturn = fromWhat + 1;

        return mReturn;
    }
}
