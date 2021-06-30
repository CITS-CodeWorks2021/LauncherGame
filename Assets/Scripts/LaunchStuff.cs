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

    GameObject spawnedBit;

    // Start is called before the first frame update
    void Start()
    {
        spawnedBit = Instantiate(stuff);
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 3; i++)
        {
            if (spawnedBit != null) spawnedBit.transform.Translate(0, 0.1f, 0);
        }
        
    }

    public void LaunchSomething()
    {
        // Here We Launch
    }
}
