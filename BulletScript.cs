using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class BulletScript : MonoBehaviour
{	
	float bulletDamage; 
	
	private void OnTriggerEnter(Collider collision)
    {
        Destroy(gameObject); 

		if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.GetComponent<PhotonView>().IsMine)
            {
                collision.gameObject.GetComponent<PhotonView>().RPC("DoDamage", RpcTarget.AllBuffered, bulletDamage);
            }         
        }		
    }
	
    public void Initialize(Vector3 _direction,float speed, float damage)
    {
		bulletDamage = damage;
		
        transform.forward = _direction;

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = _direction * speed;
    }
}