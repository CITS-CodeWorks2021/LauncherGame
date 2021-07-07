using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleTimer : MonoBehaviour
{
    bool isTiming;
    float curTime;

    public Animator uiAnims;
   

    // Update is called once per frame
    void Update()
    {
        if(isTiming)
        {
            curTime += Time.deltaTime;
            GetComponent<Text>().text = Mathf.Ceil(curTime).ToString();

            
        }
    }

    public GameObject mainPanel;
    public void TurnOnMain()
    {
        mainPanel.SetActive(true);

        uiAnims.SetTrigger("goRoot");
    }

    public void CountTime(bool shouldCount)
    {
        isTiming = shouldCount;
    }

    public void ResetTimer()
    {
        curTime = 0.0f;
    }
}
