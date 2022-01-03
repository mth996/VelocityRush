using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpPowerup : MonoBehaviour
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
                Debug.Log(CarControllerScript.gameObject);
                if (ShieldController.Shield == false)
                {
                    //CarControllerScript.enabled = false;
                    CarControllerScript.StartCoroutine(CarControllerScript.EmpStunEffect());
                    //CarControllerScript.EmpStunEffect();
                    //StartCoroutine(CarControllerScript.EmpStunEffect());
                    //CarControllerScript.EmpVisualEffect();
                    //CarControllerScript.enabled = false;
                    //CarControllerScript.enabled = true;
                }

                //CarControllerScript.enabled = false;
                //StartCoroutine(EmpBlast());
                //CarControllerScript.enabled = true;
                //EmpController.EmpAvailable = true;
            }


        }
    }

    //private IEnumerator EmpVisualEffect()
    //{
    //    empeffectson();
    //    yield return new WaitForSeconds(EmpDuration);
    //    empeffectoff();
    //}


    /*
    private IEnumerator EmpBlast()
    {
        if (ShieldController.Shield == true)
        {
            //EmpAvailable = false;
            EmpController.canDrive = true;
        }
        else
        {
           // EmpAvailable = false;
            EmpController.canDrive = false;
            empeffectson();
            yield return new WaitForSeconds(EmpDuration);
            EmpController.canDrive = true;
            empeffectoff();
        }
    }
    */

    //public void empeffectson()
    //{
    //    EmpEffect.SetActive(true);
    //}

    //public void empeffectoff()
    //{
    //    EmpEffect.SetActive(false);
    //}

}
