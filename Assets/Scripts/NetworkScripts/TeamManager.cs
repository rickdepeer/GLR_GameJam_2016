using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class TeamManager : NetworkBehaviour
{
    public GameObject[] blueTeam;
    public GameObject[] redTeam;

    public int blueTeamLength = 0;
    public int redTeamLength = 0;

    void Start ()
    {
        redTeam = new GameObject[4];
        blueTeam = new GameObject[4];
	}
	
	void Update ()
    {
	
	}

    public string joinTeam(GameObject obj)
    {
        string team;
        if (redTeamLength > blueTeamLength)
        {
            joinBlue(obj);
            obj.name = "BlueTeam("+blueTeamLength+")";
            Debug.Log(obj.transform.name + " Joined the Blue Team");
            team = "blue";
        }
        else
        {
            joinRed(obj);
            obj.name = "RedTeam(" + redTeamLength + ")";
            Debug.Log(obj.transform.name + " Joined the Red Team");
            team = "red";
        }

        return team;
    }

    void joinRed(GameObject obj)
    {
        redTeam[redTeamLength] = obj;
        redTeamLength++;
    }

    void joinBlue(GameObject obj)
    {
        blueTeam[blueTeamLength] = obj;
        blueTeamLength++;
    }
}
