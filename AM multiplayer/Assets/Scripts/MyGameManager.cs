using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGameManager : MonoBehaviour
{

    private MySphereScript mySphere;
    private Rigidbody myRb;
    private Vector3 sphereStartPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetSphere(MySphereScript sphere) {
        mySphere = sphere;
    }

    // Update is called once per frame
    public void ResetSphere() {
        if (mySphere) {
            mySphere.ResetSphere();
        }
    }
}
