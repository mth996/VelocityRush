using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerup : MonoBehaviour
{
    //private float EmpDuration = 5.0f;
    //public GameObject EmpEffect;

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision);

        if (collision.tag == "Player")
        {
            Destroy(gameObject);

            CarController CarControllerScript = collision.GetComponent<CarController>();
            if (CarControllerScript != null)
            {
                CarControllerScript.StartCoroutine(CarControllerScript.HealthRegeneration());
                    //CarControllerScript.EmpVisualEffect();
                    //CarControllerScript.enabled = false;
                    //CarControllerScript.enabled = true;
                

                //CarControllerScript.enabled = false;
                //StartCoroutine(EmpBlast());
                //CarControllerScript.enabled = true;
                //EmpController.EmpAvailable = true;
            }


        }
    }
}
