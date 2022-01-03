using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class CarController : MonoBehaviour
{
    public static CarController instance;
    private float horizontalInput;
    private float verticalInput;
    private float steerAngle;
    private float isBreaking;
    //private float BrakeLightintensity;
    private bool braked;

    public WheelCollider frontLeftWheelCollider;
    public WheelCollider frontRightWheelCollider;
    public WheelCollider rearLeftWheelCollider;
    public WheelCollider rearRightWheelCollider;
    public Transform frontLeftWheelTransform;
    public Transform frontRightWheelTransform;
    public Transform rearLeftWheelTransform;
    public Transform rearRightWheelTransform;
    public GameObject BrakeLightintensity;
    public GameObject TireSmoke;

    public bool canDrive;

    public float carEngineSoundSpeed;


    public float maxSteeringAngle = 30f;
    public static float motorForce = 1200f;
    public float brakeForce = 1000f;

    public GameObject HealingEffect;
    public GameObject EmpEffect;

    private float EmpDuration = 5.0f;

    private bool gameOver = false;

    /*private void Start()
    {
        motorForce = 500f;
        
    }*/
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        EmpDuration = 5.0f;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Awake()
    {
        instance = this;
        canDrive = true;
    }

    
    private void FixedUpdate()
    {
        //Debug.Log(carEngineSoundSpeed);
       //if (EmpController.instance.canDrive == true)
       // {
       if (canDrive)
        {
            GetInput();
            
        }
        //}
        //else
        //{
        //    Debug.Log(EmpController.instance.canDrive);
        //}

        HandleMotor();
        HandleSteering();
        UpdateWheels();
    }

    private void GetInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        isBreaking = Input.GetAxis("Brake");
        braked = Input.GetKey(KeyCode.Space);
    }

    private void HandleSteering()
    {
        steerAngle = maxSteeringAngle * horizontalInput; //* motorForce;
        frontLeftWheelCollider.steerAngle = steerAngle;
        frontRightWheelCollider.steerAngle = steerAngle;
    }

    public void brakelightson()                    
    {
        BrakeLightintensity.SetActive(true);
    }

    public void brakelightsoff()
    {
        BrakeLightintensity.SetActive(false);
    }

    public void TireSmokeon()
    {
        TireSmoke.SetActive(true);
    }

    public void TireSmokeoff()
    {
        TireSmoke.SetActive(false);
    }
    private void HandleMotor()
    {
        frontLeftWheelCollider.motorTorque = verticalInput * motorForce;
        frontRightWheelCollider.motorTorque = verticalInput * motorForce;
        rearLeftWheelCollider.motorTorque = verticalInput * motorForce;
        rearLeftWheelCollider.motorTorque = verticalInput * motorForce;

        carEngineSoundSpeed = verticalInput;
        //carEngineSoundSpeed = frontLeftWheelCollider.motorTorque / motorForce;
        //if (isBreaking = true)
        //{
        //frontLeftWheelCollider.brakeTorque = Input.GetKey(KeyCode.Space) * brakeForce;
        //frontRightWheelCollider.brakeTorque = brakeForce;
        //rearLeftWheelCollider.brakeTorque = brakeForce;
        //rearRightWheelCollider.brakeTorque = brakeForce;

        //}


        //brakeForce = isBreaking ? 5000f : 0f;
        frontLeftWheelCollider.brakeTorque = isBreaking * brakeForce;
        frontRightWheelCollider.brakeTorque = isBreaking * brakeForce;
        rearLeftWheelCollider.brakeTorque = isBreaking * brakeForce;
        rearRightWheelCollider.brakeTorque = isBreaking * brakeForce;

        if (braked)
        {
            brakelightson();
            TireSmokeon();
        }
        else
        {
            brakelightsoff();
            TireSmokeoff();
        }


    }
    private void UpdateWheels()
    {
        UpdateWheelPos(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateWheelPos(frontRightWheelCollider, frontRightWheelTransform);
        UpdateWheelPos(rearLeftWheelCollider, rearLeftWheelTransform);
        UpdateWheelPos(rearRightWheelCollider, rearRightWheelTransform);
    }

    private void UpdateWheelPos(WheelCollider wheelCollider, Transform trans)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        trans.rotation = rot;
        trans.position = pos;
    }

    

    //public IEnumerator NitroBoost ()
    ///*/{
    //yield return new WaitForSeconds(.5f);

    // Debug.Log(motorForce);
    // //motorForce += NitroPowerup.increase;
    //Debug.Log(motorForce);
    // yield return new WaitForSeconds(5);
    //motorForce = 500f;
    //Debug.Log(motorForce);

    //}

    public void empeffectson()
    {
        EmpEffect.SetActive(true);
    }

    public void empeffectoff()
    {
        EmpEffect.SetActive(false);
    }

    public IEnumerator EmpStunEffect()
    {
        canDrive = false;

        //motorForce = 0f;
        this.gameObject.GetComponent<Rigidbody>().mass = 7500f;
        //CarSlowEffect();
        TakeDamage(20);
        //currentHealth -= TakeDamage;
        //healthBar.SetHealth(currentHealth);
        empeffectson();
        yield return new WaitForSeconds(EmpDuration);
        empeffectoff();
        canDrive = true;
        this.gameObject.GetComponent<Rigidbody>().mass = 2000f;
        Debug.Log("STOP EMP");
        //motorForce = 1200f;

        //gameObject.SetActive(false);
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    public void healeffectson()
    {
        HealingEffect.SetActive(true);
    }

    public void healeffectsoff()
    {
        HealingEffect.SetActive(false);
    }

    public IEnumerator HealthRegeneration()
    {
        healeffectson();
        HealEffect(15);
        yield return new WaitForSeconds(3f);
        healeffectsoff();
    }
    void HealEffect(int heal)
    {
        currentHealth = maxHealth;

        healthBar.SetHealth(currentHealth);
    }
    private void CarSlowEffect()
    {
        //this.gameObject.GetComponent<Rigidbody>().mass = 5000;
        //frontLeftWheelCollider.motorTorque = -1000f;
        //frontRightWheelCollider.motorTorque = -1000f;
        //rearLeftWheelCollider.motorTorque = -1000f;
        //rearLeftWheelCollider.motorTorque = -1000f;
    }

   

    private void GameOver ()
    {
         PhotonNetwork.LoadLevel("GameOver");
         //return;
    }

    private void Update()
    {
        if (currentHealth <= 0)
        {
            if (gameOver == false )
            {
                GameOver();
                gameOver = true;
            }
            
        }


    }
}