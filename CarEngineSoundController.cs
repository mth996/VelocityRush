using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEngineSoundController : MonoBehaviour
{
    AudioSource audioSource;
    public float minPitch = 0.1f;
    public float maxPitch = 0.8f;
    private float carEngineSound;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = minPitch;
    }

    // Update is called once per frame
    void Update()
    {
        carEngineSound = CarController.instance.carEngineSoundSpeed;

        if (carEngineSound >= 0 )
        {
            if (carEngineSound < minPitch)
            {
                audioSource.pitch = minPitch;
            }

            else if (carEngineSound > maxPitch)
            {
                audioSource.pitch = maxPitch;
            }

            else
            {
                audioSource.pitch = carEngineSound;
            }

        }

        else if (carEngineSound < 0 )
        {
            if (carEngineSound > -minPitch)
            {
                audioSource.pitch = minPitch;
            }

            else if (carEngineSound < -maxPitch)
            {
                audioSource.pitch = maxPitch;
            }

            else
            {
                audioSource.pitch = carEngineSound;
            }
        }
            
    }
}


