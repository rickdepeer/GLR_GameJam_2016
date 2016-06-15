using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using System;

public class PlayerNetworkController : NetworkBehaviour
{
    [SyncVar]
    public string team = "";

    [SerializeField]
    Material blue;
    [SerializeField]
    Material red;

    void Start()
    {
        if (isLocalPlayer)
        {
            CmdPrint("New player has enterd and is initializing components");
            GetComponent<CharacterController>().enabled = true;
            GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;
            GetComponentInChildren<Camera>().enabled = true;
            GetComponentInChildren<AudioListener>().enabled = true;

            CmdJoinTeam();
        }
    }

    void Update()
    {
        if(team != "")
        {
            RpcChangeColor();
        }
    }

    [ClientRpc]
    void RpcChangeColor()
    {
        if(team == "red")
        {
            GetComponentInChildren<Renderer>().material = red;
            CmdPrint("Changed color to red");
        }
        else
        {
            GetComponentInChildren<Renderer>().material = blue;
            CmdPrint("Changed color to blue");
        }
        
    }

    [Command]
    void CmdJoinTeam()
    {
        team = GameObject.Find("TeamManager").GetComponent<TeamManager>().joinTeam(gameObject);
        CmdPrint(this.gameObject.name + " has completed initialisation.");
    }


    [Command]
    void CmdPrint(string p)
    {
        print(p);
    }
}
