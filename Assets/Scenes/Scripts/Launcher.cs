using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Launcher : MonoBehaviourPunCallbacks
{    void Start()
    {
        Debug.Log("Conecting To Master");
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Vonnected To Master");
        PhotonNetwork.JoinLobby();    
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Joined Lobby");
    }

    void Update()
    {
        
    }
}
