using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public static List<IPauseable> pauseables = new List<IPauseable>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static void PauseGame(bool shouldPause)
    {
        for(int i = 0; i < pauseables.Count; i++)
        {
            PauseManager.pauseables[i].PauseMe(shouldPause);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
