using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint_handler : MonoBehaviour
{
    //this is the script attached to the player that moves them back to the checkpoint when needed
    public CharacterController controlleroverride;
    public GameObject PC;
    public GameObject checkpoint;
    Rigidbody rb;
    void Start()
    {
        controlleroverride = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    public void setpoint(GameObject point)
    {
        checkpoint = point;
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Backspace))
        {
            respawn();
        }
    }
    
    public void respawn() //call this function to go back to the checkpoint
    {
        PC.transform.position = checkpoint.transform.position;
        PC.transform.rotation = checkpoint.transform.rotation;
        rb.velocity = Vector3.zero;
    }
}
