using UnityEngine;
using UnityEngine.Networking;

public class MynetworkManager : NetworkManager {
    //[SerializeField] GameObject mPlayerPrefab;

    /*public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId) {
        //base.OnServerAddPlayer(conn, playerControllerId);
        GameObject player = (GameObject)Instantiate(mPlayerPrefab, Vector3.zero, Quaternion.identity);
        //player.GetComponent<Player>().color =
        NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
    }*/
    public void MyStartHost() {
        Debug.Log("Starting Host at: " + Time.timeSinceLevelLoad);
        StartHost();
    }

    override public void OnStartHost() {
        Debug.Log("Host start at " + Time.timeSinceLevelLoad);
    }

    public override void OnStartClient(NetworkClient myClient) {
        //base.OnStartClient(myClient);
        Debug.Log("Client start requested: " + myClient + " : "+ Time.timeSinceLevelLoad);
        //InvokeRepeating("PrintDots", 0f, 1f);
    }

    public override void OnClientConnect(NetworkConnection conn) {
        //base.OnClientConnect(conn);
        Debug.Log(Time.timeSinceLevelLoad + " Client is connect to IP: " + conn.address);
        //CancelInvoke();
    }

    void PrintDots() {
        Debug.Log(".");
    }
}