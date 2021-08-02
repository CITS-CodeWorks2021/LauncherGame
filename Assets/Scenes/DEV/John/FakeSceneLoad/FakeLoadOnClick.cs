using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeLoadOnClick : MonoBehaviour
{
    public GameScene targetScene;

    private void OnMouseDown()
    {
        FakeScreenLogic.ChangeScene(targetScene);
    }
}
