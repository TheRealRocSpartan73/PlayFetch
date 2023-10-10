using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        //If a ball hits a dog, then the other object will be the dog
        if (other.CompareTag("Dog")) //If whilst falling the ball strikes the dog, remove
        {
            //Debug.Log("I'm a Ball and I Hit a dog");
            Destroy(gameObject);
        }

    }
}
