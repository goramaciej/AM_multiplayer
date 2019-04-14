using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyHud : MonoBehaviour
{
    private NetworkManager mNetworkManager;

    // Start is called before the first frame update
    void Start() {
        mNetworkManager = GetComponent<NetworkManager>();
        Debug.Log("Try to get network manager: "+mNetworkManager);
    }

    public void StartHost() {
        Debug.Log("Starting Host at " + Time.timeSinceLevelLoad);
        mNetworkManager.StartHost();
    }
}