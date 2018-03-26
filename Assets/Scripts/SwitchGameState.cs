using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGameState : MonoBehaviour
{
    public KeyCode P1Switch, P2Switch;
    char[] P1Modes = { 'r', 'p', 's' };
    char[] P2Modes = { 'r', 'p', 's' };
    public static int P1State, P2State;

    public GameObject rock;
    public float spawnRate = 0.5F;
    private float nextSpawn1 = 0.0F, nextSpawn2 = 0.0f;
    public Transform P1RockSpawn, P2RockSpawn;

    public GameObject P1Paper, P2Paper;

    public GameObject P1Scissors, P2Scissors;


    // Use this for initialization
    void Start ()
    {
        P1State = 0;
        P2State = 0;

        P1Paper = GameObject.FindWithTag("P1 Paper");
        P2Paper = GameObject.FindWithTag("P2 Paper");

        P1Scissors = GameObject.FindWithTag("P1 Scissors");
        P2Scissors = GameObject.FindWithTag("P2 Scissors");

    }
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKeyDown(P1Switch))
        {
            P1State = (P1State + 1) % 3;
        }

        if (Input.GetKeyDown(P2Switch))
        {
            P2State = (P2State + 1) % 3;
        }

        switch (P1Modes[P1State])
        {
            case 'r':
                if (Time.time > nextSpawn1)
                {
                    nextSpawn1 = Time.time + spawnRate;
                    Instantiate(rock, P1RockSpawn.position, P1RockSpawn.rotation);
                }
                P1Paper.SetActive(false);
                P1Scissors.SetActive(false);
                break;

            case 'p':
                P1Paper.SetActive(true);
                P1Scissors.SetActive(false);
                break;

            case 's':
                P1Scissors.SetActive(true);
                P1Paper.SetActive(false);
                break;
        }

        switch (P2Modes[P2State])
        {
            case 'r':
                if (Time.time > nextSpawn2)
                {
                    nextSpawn2 = Time.time + spawnRate;
                    Instantiate(rock, P2RockSpawn.position, P2RockSpawn.rotation);
                }
                P2Paper.SetActive(false);
                P2Scissors.SetActive(false);
                break;

            case 'p':
                P2Paper.SetActive(true);
                P2Scissors.SetActive(false);
                break;

            case 's':
                P2Scissors.SetActive(true); 
                P2Paper.SetActive(false);
                break;
        }
    }
}
