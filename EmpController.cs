//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class EmpController : MonoBehaviour
//{
//    public static bool EmpAvailable;
//    public static bool canDrive;
//    public GameObject EmpEffect;

//    private float EmpDuration;

//    private void Start()
//    {
//        //EmpAvailable = false;
//        //EmpDuration = 5.0f;
//        //canDrive = true;
//        //empeffectoff();
//    }
//    public void empeffectson()
//    {
//        EmpEffect.SetActive(true);
//    }

//    public void empeffectoff()
//    {
//        EmpEffect.SetActive(false);
//    }

//    private void OnTriggerEnter(Collider other)
//    {
        
//    }

//    private void Update()
//    {
//    //    if (Input.GetKey(KeyCode.RightShift) && EmpAvailable == true)
//    //    {
//    //        StartCoroutine(EmpBlast());
//    //    }
//    //    Debug.Log(EmpAvailable);
//    //    Debug.Log(EmpController.canDrive);

//    }

//    public IEnumerator EmpVisualEffect()
//    {
//        empeffectson();
//        yield return new WaitForSeconds(EmpDuration);
//        empeffectoff();
//    }
//}