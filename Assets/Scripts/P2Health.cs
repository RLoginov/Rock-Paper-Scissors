using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class P2Health : MonoBehaviour
{
    Image P2_Health;
    float maxHealth = 100f;
    public static float health;

    // Use this for initialization
    void Start()
    {
        P2_Health = GetComponent<Image>();
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        P2_Health.fillAmount = health / maxHealth;

        if (health <= 0.0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log("Player 1 wins!");
        }
    }
}
