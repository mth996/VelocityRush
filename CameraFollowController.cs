using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{

    public GameObject LookAtTarget;
    public GameObject cameraPos;

    public float cameraSpeed;


    private void Awake()
    {
        //player
    }

    private void FixedUpdate()
    {
        gameObject.transform.position = Vector3.Lerp(transform.position, cameraPos.transform.position, cameraSpeed * Time.deltaTime);

        gameObject.transform.LookAt(LookAtTarget.transform.position);
    }

}
