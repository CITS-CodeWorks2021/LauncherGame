using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YourScriptNameHere : MonoBehaviour, IPauseable
{
    public int wat;

    public void PauseMe(bool shouldPause)
    {
        // Put in Pause Behavior
    }

    public void RegisterMe()
    {
        PauseManager.pauseables.Add(this);
    }
    // Start is called before the first frame update
    void Start()
    {
        RegisterMe();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public interface IPauseable
{
    void PauseMe(bool shouldPause);

    void RegisterMe();
}