using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    //This is a simple script to tell the player what spawn point to use.
    //Simply attach this script to a gameobject with a collider that is a trigger, and optionally set the spawn point to an empty object at the exact location you want them to spawn.
    //if no spawn point is set then it will default to the triggers position.
    public GameObject spawnpoint;
    private void OnTriggerEnter(Collider other) //rename this to OnTriggerEnter2D if your game is 2d
    {
        if (other.tag == "Player") {
        other.gameObject.GetComponent<checkpoint_handler>().setpoint(respawnpoint());
        }
    }

    private GameObject respawnpoint()
    {
        if (spawnpoint != null)
            return spawnpoint;
        else
            return gameObject;
    }
}
