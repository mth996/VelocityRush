using UnityEngine;

public class NitroPowerup : MonoBehaviour
{
    public static float increase = 1000f;

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision);
        
        if (collision.tag == "Player")
        {
            Destroy(gameObject);

            CarController CarControllerScript = collision.GetComponent<CarController>();
            if (CarControllerScript != null)
            {
                NitroController.NitroAvailable = true;
            }

            

            //script name = NitroController
            // public staic bool isNitro;

            //Start(){ isNitro = false;
            // in nitro script
            /* update()
            {
            if (Input.GetKey(KeyCode.LeftShift) && isNitro == true)
            {
                StartCoroutine(NitroBoost());
            }
                

            privatet enuaomatr NitroBoost ()
            {
             motorForce += NitroPowerup.increase;
              Debug.Log(motorForce);
                // activate the animation
             yield return new WaitForSeconds(NitroDuration);
              motorForce = 500f;
            }

            } */

            /*
            GameObject CarBlack = collision.gameObject;
            CarController CarControllerScript = CarBlack.GetComponent<CarController>();
            if (CarControllerScript)
            {
                CarControllerScript.motorForce += increase;
            } */
        }
    }


}
