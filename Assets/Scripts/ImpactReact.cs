using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactReact : MonoBehaviour
{
    public bool shouldShake;
    public float simpleAmount;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!shouldShake) return;

        CameraShake.onSimpleShake.Invoke(simpleAmount);
    }

}






/* Notes
    public bool fancyShake;
    public float reactAmount;
    public float hShake, vShake, shakeTime;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!fancyShake) CameraShake.onShake.Invoke(reactAmount);
        if(fancyShake) CameraShake.onShook.Invoke(hShake, vShake, shakeTime);
    }

*/
