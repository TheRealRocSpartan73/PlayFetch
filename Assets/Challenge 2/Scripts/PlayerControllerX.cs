using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private bool canSpawnDog = true;  //Initially can spawn a dog;
    private float pressSpeed = 0.75f; //Only spam a dog in just under a second, not as fast as can press space key
    private float nextPress = -1f; //Intially set this to negative so intial dog is spawned

    // Update is called once per frame
    void Update()
    {
        
        if(Time.time > nextPress) //If time elapsed is greater than our delay
        {
            canSpawnDog = true;
        }

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)  && canSpawnDog == true)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);//Spawn dog
            nextPress = Time.time + pressSpeed; //Reset time allowed to perform another press of key
            Debug.Log("Farmer spawning Dog in " + nextPress);
            canSpawnDog = false;
        }
    }
}
