using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Dog")) //If whilst falling the ball strikes the dog, remove
        {
            Debug.Log("Hit a dog");
            Destroy(gameObject);
        }

    }
}
