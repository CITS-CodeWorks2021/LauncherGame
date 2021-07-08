using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public AnimationCurve animCurve, speedCurve;
    public Transform refPointOne, refPointTwo;
    public float moveTime;

    bool isForward = true;
    float curTime;
    float curPercent;

    public bool isTimed;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        curTime = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(isTimed)
        {
            if (curTime >= moveTime)
            {
                isForward = !isForward;
                curTime = 0;
            }

            curPercent = curTime / moveTime;

            curPercent = animCurve.Evaluate(curPercent);

            if (isForward)
            {
                transform.position =
                Vector3.Lerp(refPointOne.position, refPointTwo.position, curPercent);
            }
            else
            {
                transform.position =
                Vector3.Lerp(refPointTwo.position, refPointOne.position, curPercent);
            }
            curTime += Time.deltaTime;
        }
        else
        {

            float distance;
            Vector3 moveDirect;

            if(isForward)
            {
                moveDirect = refPointOne.position - transform.position;
                distance = Vector3.Distance(refPointOne.position, transform.position);
                
            }
            else
            {
                moveDirect = refPointTwo.position - transform.position;
                distance = Vector3.Distance(refPointTwo.position, transform.position);
            }

            float totalDistance = Vector3.Distance(refPointTwo.position, refPointOne.position);
            float percentDistance = distance / totalDistance;
            float moveMulti = speedCurve.Evaluate(percentDistance) * speed;
            moveDirect = moveDirect.normalized;
            moveDirect *= moveMulti;
            transform.Translate(moveDirect);
            if (distance < 0.1f) isForward = !isForward;
        }
        
    }
}
