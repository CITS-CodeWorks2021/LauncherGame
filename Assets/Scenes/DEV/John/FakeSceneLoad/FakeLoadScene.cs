using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeLoadScene : MonoBehaviour
{
    public GameScene myScene;
    // Start is called before the first frame update
    private void Start()
    {
        FakeScreenLogic.OnChangedScene.AddListener(HandleSceneChange);
    }

    void HandleSceneChange()
    {
        if (FakeScreenLogic.TheScene == myScene) gameObject.SetActive(true);
        else gameObject.SetActive(false);
    }
}
