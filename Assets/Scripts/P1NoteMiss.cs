using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1NoteMiss : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Note")
        {
            float damage = 1.0f;

            if (SwitchGameState.P1State == 1 && SwitchGameState.P2State == 2)
                damage = 2.0f * damage;

            if (SwitchGameState.P1State == 1 && SwitchGameState.P2State == 3)
                damage = 0.5f * damage;

            if (SwitchGameState.P1State == 2 && SwitchGameState.P2State == 1)
                damage = 0.5f * damage;

            if (SwitchGameState.P1State == 2 && SwitchGameState.P2State == 3)
                damage = 2.0f * damage;

            if (SwitchGameState.P1State == 3 && SwitchGameState.P2State == 1)
                damage = 2.0f * damage;

            if (SwitchGameState.P1State == 3 && SwitchGameState.P2State == 2)
                damage = 0.5f * damage;

            P1Health.health -= damage;

            Destroy(collision.gameObject);
        }
    }
}
