using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeLoadTrigger : MonoBehaviour
{
    public GameScene TargetScene;
    public Transform safeReturnLoc;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FakeScreenLogic.ChangeScene(TargetScene);
        collision.gameObject.transform.position = safeReturnLoc.position;
    }
}
