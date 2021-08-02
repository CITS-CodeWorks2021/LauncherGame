using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeLoadPlayer : MonoBehaviour
{
    public float moveSpeed;

    Vector2 startLocation;

    private void Start()
    {
        startLocation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(
            Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime,
            Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime,
            0
            );
        
    }
}
