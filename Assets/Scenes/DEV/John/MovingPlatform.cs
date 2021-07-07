using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public AnimationCurve animCurve;
    public Transform refPointOne, refPointTwo;
    public float moveTime;

    bool isForward;
    float curTime;
    // Start is called before the first frame update
    void Start()
    {
        curTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(curTime >= moveTime)
        {
            isForward = !isForward;
            curTime = 0;
        }

        float curPercent = curTime / moveTime;
        curPercent = animCurve.Evaluate(curPercent);
        if (isForward)
        {
            transform.position =
            Vector3.Lerp(refPointOne.position, refPointTwo.position, curPercent);
        }
        else
        {
            transform.position =
            Vector3.Lerp(refPointOne.position, refPointTwo.position, curPercent);
        }
        
        
    }
}
