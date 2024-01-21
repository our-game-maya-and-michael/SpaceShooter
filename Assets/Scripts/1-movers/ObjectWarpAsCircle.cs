using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectWarpAsCircle : MonoBehaviour
{
    public float leftBoundary = -10f;  // Adjust these values based on your game's world size
    public float rightBoundary = 10f;

    void Update()
    {
        Vector3 newPosition = transform.position;

        // Check if the spaceship crosses the left boundary
        if (transform.position.x < leftBoundary)
        {
            newPosition.x = rightBoundary;
        }
        // Check if the spaceship crosses the right boundary
        else if (transform.position.x > rightBoundary)
        {
            newPosition.x = leftBoundary;
        }

        // Update the position
        transform.position = newPosition;
    }
}
