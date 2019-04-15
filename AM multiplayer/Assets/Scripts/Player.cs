using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;


public class Player : NetworkBehaviour
{
    private Vector3 inputValue;
   
    void Update() {
        if (!isLocalPlayer) {
            return;
        }
        inputValue.x = Input.GetAxis("Horizontal");
        inputValue.z = Input.GetAxis("Vertical");
        inputValue.y = 0f;

        transform.Translate(inputValue);
    }

    public override void OnStartLocalPlayer() {
        GetComponentInChildren<Camera>().enabled = true;
        //Debug.Log("Player started: " + isLocalPlayer);
    }
}
