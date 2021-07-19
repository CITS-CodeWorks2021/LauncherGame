using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickController : MonoBehaviour
{
    public float moveSpeed;
    // Start is called before the first frame update

    public float horizontal, vertical;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 frameMovement = Vector2.zero;

        frameMovement.x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        frameMovement.y = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate((Vector3)frameMovement);
    }
}
