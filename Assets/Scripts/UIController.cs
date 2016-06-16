using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public int kills;
    public int deaths;
    public int Health;
    public int score;
    public int teamScore;

    public GameObject ScoreText;
    public GameObject DeathText;
    public GameObject KillText;
    public GameObject TeamScoreText;
    public GameObject HealthText;

    void Start ()
    {
	
	}
	
	void Update ()
    {
        addScore(34);

    }



    public void addDeath()
    {
        deaths++;
        ScoreText.GetComponent<Text>().text = "Deaths: " + deaths;
    }

    public void addKill()
    {
        kills++;
        KillText.GetComponent<Text>().text = "Kills: " + kills;
    }

    public void addScore(int amount)
    {
        score++;
        ScoreText.GetComponent<Text>().text = "Score: " + score;
    }

    public void addTeamScore(int amount)
    {
        teamScore++;
        TeamScoreText.GetComponent<Text>().text = "Team Score: " + teamScore;
    }

    public void damageHealth(int amount)
    {
        //
    }

}
