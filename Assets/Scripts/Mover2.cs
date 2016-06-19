using UnityEngine;
using System.Collections;

public class Mover2 : MonoBehaviour
{
    private Vector3 startPositie;
    private Vector3 playerPositie;
    private int waitToStart;

    private int start = 0;

    public Transform Player;

    void Start()
    {
        startPositie = gameObject.transform.position;
        playerPositie = Player.gameObject.transform.position;
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * -1000f);
    }

    void Update()
    {

        print(gameObject.transform.position);
        print(startPositie);

        if (gameObject.transform.position.z > 70)
        {
            print("TEST");
            gameObject.transform.position = startPositie;
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Player.transform.position = playerPositie;
        }
    }
}
