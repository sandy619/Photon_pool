using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class CreateRoom : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private Text _roomname;

    public void CreateRoomButton()
    {
        if (!PhotonNetwork.IsConnected)
            return;

        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 4;
        PhotonNetwork.JoinOrCreateRoom(_roomname.text, options, TypedLobby.Default);
    }

    public override void OnCreatedRoom()
    {
        print("Created Room Succesfully ");
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        print("Room Creation Failed " + message);
    }
}
