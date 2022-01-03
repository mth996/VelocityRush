using UnityEngine;

public class ShieldPowerup : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision);

        if (collision.tag == "Player")
        {
            Destroy(gameObject);

            CarController CarControllerScript = collision.GetComponent<CarController>();
            if (CarControllerScript != null)
            {
                ShieldController.ShieldAvailable = true;
            }

        }
    }
}