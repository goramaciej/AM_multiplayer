using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyHud : MonoBehaviour
{
    private NetworkManager mNetworkManager;

    public void StartHost() {
        mNetworkManager = GetComponent<NetworkManager>();
        mNetworkManager.StartHost();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
