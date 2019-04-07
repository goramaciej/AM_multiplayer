using UnityEngine;
using UnityEngine.Networking;

public class MynetworkManager : NetworkManager {
    [SerializeField] GameObject mPlayerPrefab;

    public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId) {
        //base.OnServerAddPlayer(conn, playerControllerId);
        GameObject player = (GameObject)Instantiate(mPlayerPrefab, Vector3.zero, Quaternion.identity);
        //player.GetComponent<Player>().color =
        NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
    }

    public void mStartHost() {

    }
}