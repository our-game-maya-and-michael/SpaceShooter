using UnityEngine;
using System.Collections;

/**
 * This component spawns the given laser-prefab whenever the player clicks a given key.
 * It also updates the "scoreText" field of the new laser.
 */
public class LaserShooter: ClickSpawner {
    [SerializeField] NumberField scoreField;
    [SerializeField] float cooldownDuration = 2.0f; // Cooldown duration in seconds
    private bool canShoot = true; // Flag to check if shooting is allowed

    protected override GameObject spawnObject()
    {
        if (canShoot)
        {
            GameObject newObject = base.spawnObject(); // base = super

            // Modify the text field of the new object.
            ScoreAdder newObjectScoreAdder = newObject.GetComponent<ScoreAdder>();
            if (newObjectScoreAdder)
                newObjectScoreAdder.SetScoreField(scoreField);

            StartCoroutine(Cooldown()); // Start the cooldown coroutine
            return newObject;
        }
        return null;
    }

    IEnumerator Cooldown()
    {
        canShoot = false; // Disable shooting
        yield return new WaitForSeconds(cooldownDuration); // Wait for the cooldown
        canShoot = true; // Re-enable shooting
    }
}
