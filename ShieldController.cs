using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour
{
    public static bool ShieldAvailable;
    public static bool Shield;
    public GameObject ShieldEffect;

    private float ShieldDuration;

    private void Start()
    {
        ShieldAvailable = false;
        ShieldDuration = 10.0f;
        Shield = false;
        shieldeffectoff();
    }
    public void shieldeffectson()
    {
        ShieldEffect.SetActive(true);
    }

    public void shieldeffectoff()
    {
        ShieldEffect.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Tab) && ShieldAvailable == true)
        {
            StartCoroutine(EmpArmor());
        }
        Debug.Log(ShieldAvailable);
        //Debug.Log(EmpController.instance.canDrive);

    }

    private IEnumerator EmpArmor()
    {
        ShieldAvailable = false;
        ShieldController.Shield = true;
        shieldeffectson();
        yield return new WaitForSeconds(ShieldDuration);
        ShieldController.Shield = false;
        shieldeffectoff();
    }
}