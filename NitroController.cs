using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NitroController : MonoBehaviour
{
    public static bool NitroAvailable;

    private float NitroDuration;
    public GameObject nitrous;

    private void Start()
    {
        NitroAvailable = false;
        NitroDuration = 5.0f;
        nitrousoff();
    }
    public void nitrouson()
    {
        nitrous.SetActive(true);
    }

    public void nitrousoff()
    {
        nitrous.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && NitroAvailable == true)
        {
            StartCoroutine(NitroBoost());
        }
        Debug.Log(NitroAvailable);
        Debug.Log(CarController.motorForce);

    }

    private IEnumerator NitroBoost()
    {
        NitroAvailable = false;
        CarController.motorForce += NitroPowerup.increase;
        nitrouson();
        yield return new WaitForSeconds(NitroDuration);
        CarController.motorForce = 1200f;
        nitrousoff();
    }
}