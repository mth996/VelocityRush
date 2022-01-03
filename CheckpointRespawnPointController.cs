using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointRespawnPointController : MonoBehaviour
{
    private int checkPointNum;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name.Contains("1"))
        {
            checkPointNum = 1;
        }

        else if (gameObject.name.Contains("2"))
        {
            checkPointNum = 2;
        }

        else if (gameObject.name.Contains("3"))
        {
            checkPointNum = 3;
        }

        else if (gameObject.name.Contains("4"))
        {
            checkPointNum = 4;
        }

        else if (gameObject.name.Contains("5"))
        {
            checkPointNum = 5;
        }

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("CHECKPOINT RESPAWN" + gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "RespawnTriggerCollider")
        {
            RespawnController respawnScript = other.GetComponent<RespawnController>();
            respawnScript.checkpointsRespawnPoint = checkPointNum;
            //this.enabled = false;
            //other.GetComponent
        }
        //other.GetComponent<>
    }


}
