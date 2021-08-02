using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuickTimer : MonoBehaviour
{
    Text myText;
    float timer;

    private void Start()
    {
        myText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(QuickLogic.State == TimerState.InGame)
        {
            timer += Time.deltaTime;
            myText.text = timer.ToString("F0");
        }

        if(QuickLogic.State == TimerState.Paused)
        {

        }
        
    }


    // Example of use in IEnumerator and Quick Animator example
    Animator testAnim;
    IEnumerator SomeTimingThing()
    {
        bool isGoing = true;
        while(isGoing)
        {
            if (QuickLogic.State == TimerState.InGame)
            {
                testAnim.speed = 1;
            }
            else testAnim.speed = 0;
            yield return new WaitForEndOfFrame();
        }

        
    }
}
