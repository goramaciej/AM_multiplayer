using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MySphereScript : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 startPosition;
    private MyGameManager mg;

    // Start is called before the first frame update
    void Start()
    {
        mg = FindObjectOfType<MyGameManager>();
        mg.SetSphere(this);

        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       if ((Input.GetAxis("Horizontal") != 0) && rb) {

            rb.AddForce(transform.right * 30 * Input.GetAxis("Horizontal"));
        }
    }

    public void ResetSphere() {
        transform.position = startPosition;
    }
}
