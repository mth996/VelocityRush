using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class PlayerSetup : MonoBehaviourPunCallbacks
{
    //public Camera PlayerCamera;
    public Camera RearviewCamera;
    public Camera MinimapCamera;
    public GameObject Rearview;
    public GameObject Minimap;

    //public TextMeshProUGUI PlayerNameText;

    // Start is called before the first frame update
    void Start()
    {
        if (PhotonNetwork.CurrentRoom.CustomProperties.ContainsValue("rc"))
        {
            if (photonView.IsMine)
            {
                Debug.Log("me");
                //enable carMovement script and camera
                GetComponent<CarController>().enabled = true;
                //GetComponent<EmpController>().enabled = true;
                GetComponent<NitroController>().enabled = true;
                GetComponent<ShieldController>().enabled = true;
                GetComponent<CarEngineSoundController>().enabled = true;
                GetComponent<Reset>().enabled = false;
                RearviewCamera.enabled = true;
                Debug.Log(RearviewCamera.enabled);
                //Rearview.enabled = true;
                MinimapCamera.enabled = true;
                Debug.Log(MinimapCamera.enabled);

                Rearview.SetActive(true);
                Minimap.SetActive(true);
                //Minimap.enabled = true;
                //GetComponent<LapController>().enabled = true;
                //PlayerCamera.enabled = true;
            }
            else
            {
                //Player is remote. Disable CarMovement script and camera.
                GetComponent<CarController>().enabled = false;
                //GetComponent<EmpController>().enabled = false;
                GetComponent<NitroController>().enabled = false;
                GetComponent<ShieldController>().enabled = false;
                GetComponent<CarEngineSoundController>().enabled = false;
                GetComponent<Reset>().enabled = false;
                RearviewCamera.enabled = false;
                //Rearview.enabled = true;
                MinimapCamera.enabled = false;
                Rearview.SetActive(false);
                Minimap.SetActive(false);
                //Minimap.enabled = true;
                //GetComponent<LapController>().enabled = false;
                //PlayerCamera.enabled = false;
            }

        }
        else if (PhotonNetwork.CurrentRoom.CustomProperties.ContainsValue("dr"))
        {
            if (photonView.IsMine)
            {
                Debug.Log("DR");
                //enable carMovement script and camera
                GetComponent<CarController>().enabled = true;
                //GetComponent<EmpController>().enabled = true;
                GetComponent<NitroController>().enabled = true;
                GetComponent<ShieldController>().enabled = true;
                GetComponent<CarEngineSoundController>().enabled = true;
                //GetComponent<CarController>().enabled = true;
                RearviewCamera.enabled = true;
                //Rearview.enabled = true;
                MinimapCamera.enabled = true;
                Rearview.SetActive(true);
                Minimap.SetActive(true);
                //Minimap.enabled = true;
                //GetComponent<LapController>().enabled = true;
                //PlayerCamera.enabled = true;
            }
            else
            {
                //Player is remote. Disable CarMovement script and camera.
                GetComponent<CarController>().enabled = false;
                // GetComponent<EmpController>().enabled = false;
                GetComponent<NitroController>().enabled = false;
                GetComponent<ShieldController>().enabled = false;
                GetComponent<CarEngineSoundController>().enabled = false;
                RearviewCamera.enabled = false;
                //Rearview.enabled = true;
                MinimapCamera.enabled = false;
                Rearview.SetActive(false);
                Minimap.SetActive(false);
                //Minimap.enabled = true;
                //GetComponent<LapController>().enabled = false;
                //PlayerCamera.enabled = false;
            }
        }
        else if (PhotonNetwork.CurrentRoom.CustomProperties.ContainsValue("sr"))
        {
            if (photonView.IsMine)
            {
                Debug.Log("me");
                //enable carMovement script and camera
                GetComponent<CarController>().enabled = true;
                //GetComponent<EmpController>().enabled = true;
                GetComponent<NitroController>().enabled = true;
                GetComponent<ShieldController>().enabled = true;
                GetComponent<CarEngineSoundController>().enabled = true;
                RearviewCamera.enabled = true;
                Debug.Log(RearviewCamera.enabled);
                //Rearview.enabled = true;
                MinimapCamera.enabled = true;
                Debug.Log(MinimapCamera.enabled);

                Rearview.SetActive(true);
                Minimap.SetActive(true);
                //Minimap.enabled = true;
                //GetComponent<LapController>().enabled = true;
                //PlayerCamera.enabled = true;
            }
            else
            {
                //Player is remote. Disable CarMovement script and camera.
                GetComponent<CarController>().enabled = false;
                //GetComponent<EmpController>().enabled = false;
                GetComponent<NitroController>().enabled = false;
                GetComponent<ShieldController>().enabled = false;
                GetComponent<CarEngineSoundController>().enabled = false;
                RearviewCamera.enabled = false;
                //Rearview.enabled = true;
                MinimapCamera.enabled = false;
                Rearview.SetActive(false);
                Minimap.SetActive(false);
                //Minimap.enabled = true;
                //GetComponent<LapController>().enabled = false;
                //PlayerCamera.enabled = false;
            }
        }
        //SetPlayerUI();
        else if (PhotonNetwork.CurrentRoom.CustomProperties.ContainsValue("lr"))
        {
            if (photonView.IsMine)
            {
                Debug.Log("me");
                //enable carMovement script and camera
                GetComponent<CarController>().enabled = true;
                //GetComponent<EmpController>().enabled = true;
                GetComponent<NitroController>().enabled = true;
                GetComponent<ShieldController>().enabled = true;
                GetComponent<CarEngineSoundController>().enabled = true;
                RearviewCamera.enabled = true;
                Debug.Log(RearviewCamera.enabled);
                //Rearview.enabled = true;
                MinimapCamera.enabled = true;
                Debug.Log(MinimapCamera.enabled);

                Rearview.SetActive(true);
                Minimap.SetActive(true);
                //Minimap.enabled = true;
                //GetComponent<LapController>().enabled = true;
                //PlayerCamera.enabled = true;
            }
            else
            {
                //Player is remote. Disable CarMovement script and camera.
                GetComponent<CarController>().enabled = false;
                //GetComponent<EmpController>().enabled = false;
                GetComponent<NitroController>().enabled = false;
                GetComponent<ShieldController>().enabled = false;
                GetComponent<CarEngineSoundController>().enabled = false;
                RearviewCamera.enabled = false;
                //Rearview.enabled = true;
                MinimapCamera.enabled = false;
                Rearview.SetActive(false);
                Minimap.SetActive(false);
                //Minimap.enabled = true;
                //GetComponent<LapController>().enabled = false;
                //PlayerCamera.enabled = false;
            }
        }

        /* private void SetPlayerUI()
         {
             if (PlayerNameText != null)
             {
                 PlayerNameText.text = photonView.Owner.NickName;
                 if (photonView.IsMine)
                 {
                     PlayerNameText.gameObject.SetActive(false);
                 }
             }*/
    }
}