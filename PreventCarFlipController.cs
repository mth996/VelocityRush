using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreventCarFlipController : MonoBehaviour
{
    public GameObject CarObj;

    // Update is called once per frame
    void Update()
    {
      //  PreventCarFlip();
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.name == "mountain-race-track") || (other.name == "mountain-terrain"))
        {
            CarObj.transform.rotation = Quaternion.Euler(0f, CarObj.transform.rotation.y, 0f);
            //CarObj.transform.eulerAngles = new Vector3(0f, CarObj.transform.rotation.y, 0f);
        }
    }

    //private void PreventCarFlip()
    //{
    //    Debug.Log("FLIPP11");
    //    //Debug.log
    //    if (CarObj.transform.rotation.x >= 30 || CarObj.transform.rotation.x <= -30 || CarObj.transform.rotation.z <= -30 || CarObj.transform.rotation.z >= 30)
    //    {
    //        CarObj.transform.rotation = Quaternion.Euler(0f, CarObj.transform.rotation.y, 0f);
    //        Debug.Log("FLIPP");
    //    }
    //}
}
