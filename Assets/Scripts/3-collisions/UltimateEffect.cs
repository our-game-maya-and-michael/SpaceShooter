using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UltimateEffect : MonoBehaviour
{
    [SerializeField] int pointsPerEnemy = 5; // Points awarded per enemy destroyed

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            NumberField playerScoreField = other.GetComponentInChildren<NumberField>();

            if (playerScoreField != null)
                {
                    // Destroy all enemies and add points for each
                    var enemies = GameObject.FindGameObjectsWithTag("Enemy");
                    foreach (var enemy in enemies)
                    {
                        Destroy(enemy);
                        playerScoreField.AddNumber(pointsPerEnemy);
                    }
                }

            // Destroy the Ultimate object after use
            Destroy(gameObject);
        }
    }
}
