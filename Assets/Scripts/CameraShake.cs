using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CameraShake : MonoBehaviour
{
	Vector3 startPos;

    public static UnityEvent<float> onSimpleShake =
        new UnityEvent<float>();

    float simpleAmount;


    void Start()
	{
		startPos = transform.position;

        onSimpleShake.AddListener(HandleOnSimpleShake);

	}

    private void HandleOnSimpleShake(float amount)
    {
        simpleAmount = amount;
    }

    private void Update()
    {
        Vector3 shakePos = startPos;

        if(simpleAmount > 0)
        {
            // Shake it Up
            shakePos.x += Random.Range(-simpleAmount, simpleAmount);
            shakePos.y += Random.Range(-simpleAmount, simpleAmount);

            transform.position = shakePos;
            simpleAmount -= Time.deltaTime;
        }
    }
}











/*  --- Notes . . . in case I need a reminder :)
    using UnityEngine.Events;

    public static UnityEvent<float> onShake = new UnityEvent<float>();
    public static UnityEvent<float, float, float> onShook = new UnityEvent<float, float, float>();

    Vector3 startPos;
    float shakeAmount;

    float hShake, vShake, shakeTime, startShakeTime;

    // Start is called before the first frame update
    void Start()
    {
        onShake.AddListener(HandleOnShake);
        onShook.AddListener(HandleOnShook);
        startPos = transform.position;
    }

    private void HandleOnShake(float amount)
    {
        shakeAmount = amount;
    }

    private void HandleOnShook(float hAmount, float vAmount, float time)
    {
        hShake = hAmount;
        vShake = vAmount;
        shakeTime = time;
        startShakeTime = time;
    }


    // Update is called once per frame
    void Update()
    {
        float ranNum;

        Vector3 ranVector = startPos;

        if (shakeAmount > 0)
        {
            ranNum = Random.Range(-shakeAmount, shakeAmount);
            ranVector.x += ranNum;

            ranNum = Random.Range(-shakeAmount, shakeAmount);
            ranVector.y += ranNum;

            transform.position = ranVector;
            shakeAmount -= Time.deltaTime;
        }

        float shakeLeft = shakeTime / startShakeTime;

        if(shakeTime > 0)
        {
            ranNum = Random.Range(-hShake * shakeLeft, hShake * shakeLeft);
            ranVector.x += ranNum;

            ranNum = Random.Range(-vShake * shakeLeft, vShake * shakeLeft);
            ranVector.y += ranNum;

            transform.position = ranVector;
            shakeTime -= Time.deltaTime;
        }

    }



 */
