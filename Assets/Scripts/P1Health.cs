using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class P1Health : MonoBehaviour
{
    Image P1_Health;
    float maxHealth = 100f;
    public static float health;

    // Use this for initialization
    void Start()
    {
        P1_Health = GetComponent<Image>();
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        P1_Health.fillAmount = health / maxHealth;

        if(health <= 0.0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log("Player 2 wins!");
        }
    }
}
