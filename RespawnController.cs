using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnController : MonoBehaviour
{
    private Vector3 RespawnPos;
    //private Vector3 RespawnRotation;
    private Quaternion RespawnRotation;
    public int checkpointsRespawnPoint = 0;
    public GameObject CarObj;

    // Start is called before the first frame update
    void Start()
    {
        checkpointsRespawnPoint = 0;
        //Car = gameObject.transform.parent
        /*
        RespawnRotation = Quaternion.Euler(50f, 60f, 70f);
        gameObject.transform.rotation = RespawnRotation;

        if (gameObject.name.Contains ("1"))
        {
            RespawnPos = new Vector3(5.0f, 4.0f, 7.0f);
            RespawnRotation = Quaternion.Euler(50f, 60f, 70f);

        }

        else if (gameObject.name.Contains("2"))
        {
            RespawnPos = new Vector3(5.0f, 4.0f, 7.0f);
            RespawnRotation = Quaternion.Euler(50f, 60f, 70f);

        }

        else if (gameObject.name.Contains("3"))
        {
            RespawnPos = new Vector3(5.0f, 4.0f, 7.0f);
            RespawnRotation = Quaternion.Euler(50f, 60f, 70f);
        }

        else if (gameObject.name.Contains("4"))
        {
            RespawnPos = new Vector3(5.0f, 4.0f, 7.0f);
            RespawnRotation = Quaternion.Euler(50f, 60f, 70f);
        }

        else if (gameObject.name.Contains("5"))
        {
            RespawnPos = new Vector3(5.0f, 4.0f, 7.0f);
            RespawnRotation = Quaternion.Euler(50f, 60f, 70f);
        }

        else if (gameObject.name.Contains("6"))
        {
            RespawnPos = new Vector3(5.0f, 4.0f, 7.0f);
            RespawnRotation = Quaternion.Euler(50f, 60f, 70f);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(checkpointsRespawnPoint);
        //Debug.Log(transform.parent.transform.par);
        //PreventCarFlip();
    }

    

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other);
        if (other.tag == "Terrain")
        {
            Debug.Log("TOUCH GROUND");
            if (checkpointsRespawnPoint == 0)
            {
                Debug.Log("RESPAWN STARTING");

                //RespawnPos = new Vector3(-154.477f, 4.654119f, 153.5839f); 
                //RespawnRotation = new Vector3 (0f, 33.347f, 0f);
                //CarObj.transform.position = RespawnPos;
                //CarObj.transform.eulerAngles = RespawnRotation;


                RespawnPos = new Vector3(-155.5107f, 4.89f, 151.9242f);
                RespawnRotation = Quaternion.Euler(0f, 38.287f, 0f);
                CarObj.transform.position = RespawnPos;
                CarObj.transform.rotation = RespawnRotation;

            }

            else if (checkpointsRespawnPoint == 1)
            {
                Debug.Log("RESPAWN 1STTTTT");

                //RespawnPos = new Vector3(-144.412f, 5.891924f, 167.2943f);
                //RespawnRotation = new Vector3(0f, 38.569f, 0f);
                //CarObj.transform.position = RespawnPos;
                //CarObj.transform.eulerAngles = RespawnRotation;

                RespawnPos = new Vector3(-144.412f, 5.891924f, 167.2943f);
                RespawnRotation = Quaternion.Euler(0f, 38.569f, 0f);
                CarObj.transform.position = RespawnPos;
                CarObj.transform.rotation = RespawnRotation;

            }

            else if (checkpointsRespawnPoint == 2)
            {
                Debug.Log("RESPAWN 2NDDDDD");

                //RespawnPos = new Vector3(-45.7f, 12.90368f, 232f);
                //RespawnRotation = new Vector3(0f, 77.8f, 0f);
                //CarObj.transform.position = RespawnPos;
                //CarObj.transform.eulerAngles = RespawnRotation;

                RespawnPos = new Vector3(-45.7f, 12.90368f, 232f);
                RespawnRotation = Quaternion.Euler(0f, 77.8f, 0f);
                CarObj.transform.position = RespawnPos;
                CarObj.transform.rotation = RespawnRotation;
            }

            else if (checkpointsRespawnPoint == 3)
            {
                Debug.Log("RESPAWN 3RDDD");

                //RespawnPos = new Vector3(181.8f, -1.870709f, 28.3f);
                //RespawnRotation = new Vector3(0f, 219.4f, 0f);
                //CarObj.transform.position = RespawnPos;
                //CarObj.transform.eulerAngles = RespawnRotation;

                RespawnPos = new Vector3(181.8f, -1.870709f, 28.3f);
                RespawnRotation = Quaternion.Euler(0f, 219.4f, 0f);
                CarObj.transform.position = RespawnPos;
                CarObj.transform.rotation = RespawnRotation;


            }

            else if (checkpointsRespawnPoint == 4)
            {
                Debug.Log("RESPAWN 4THHHHH");

                //RespawnPos = new Vector3(-45.8f, 11.23934f, -219.9f);
                //RespawnRotation = new Vector3(0f, 203f, 0f);
                //CarObj.transform.position = RespawnPos;
                //CarObj.transform.eulerAngles = RespawnRotation;

                RespawnPos = new Vector3(-45.8f, 11.23934f, -219.9f);
                RespawnRotation = Quaternion.Euler(0f, 203f, 0f);
                CarObj.transform.position = RespawnPos;
                CarObj.transform.rotation = RespawnRotation;
            }

            else if (checkpointsRespawnPoint == 5)
            {
                Debug.Log("RESPAWN 5THHHHH");

                //RespawnPos = new Vector3(-160.3f, 3.091498f, -139.4f);
                //RespawnRotation = new Vector3(0f, -22f, 0f);
                //CarObj.transform.position = RespawnPos;
                //CarObj.transform.eulerAngles = RespawnRotation;

                RespawnPos = new Vector3(-160.3f, 3.091498f, -139.4f);
                RespawnRotation = Quaternion.Euler(0f, -22f, 0f);
                CarObj.transform.position = RespawnPos;
                CarObj.transform.rotation = RespawnRotation;
            }

        }
    }
}
