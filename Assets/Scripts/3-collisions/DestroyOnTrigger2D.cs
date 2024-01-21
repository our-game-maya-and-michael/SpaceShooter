﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    private int hitsTaken = 0;
    private int maxHits = 3;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            if ((maxHits > hitsTaken) && this.gameObject.tag == "Player")
            {
                hitsTaken++;

                if (maxHits <= hitsTaken)
                {
                    Destroy(this.gameObject);
                }
            }

            else {
                Destroy(this.gameObject);
            }

            Destroy(other.gameObject);
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }
}
