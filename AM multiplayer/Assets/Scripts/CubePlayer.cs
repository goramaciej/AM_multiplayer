//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class CubePlayer : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        Vector3 delta = Vector3.zero;

        float dx = transform.position.x;
        if (Input.GetAxis("Horizontal") != 0) {
            dx += Input.GetAxis("Horizontal");
        }

        float dy = transform.position.y;
        if (Input.GetAxis("Vertical") != 0) {
            dy += Input.GetAxis("Vertical");
        }
        delta.x = dx;
        delta.y = dy;

        transform.position = delta;
    }
}
