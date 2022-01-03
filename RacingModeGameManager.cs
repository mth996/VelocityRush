using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RacingModeGameManager : MonoBehaviour
{
    public GameObject[] PlayerPrefabs; 
	public Transform[] InstantiatePositions;

	public Text TimeUIText;	
	public GameObject[] FinishOrderUIGameObjects;
	
	public List<GameObject> lapTriggers = new List<GameObject>();

    //public GameObject blackCar;
    //public GameObject yellowCar;
    //public GameObject redCar;

    //public Transform startPos1; // black
    //public Transform startPos2; // yellow
   // public Transform startPos3; // red

    public CameraFollowController carCamera;


    //Singeleton Implementation
    public static RacingModeGameManager instance = null;

    private void Awake()
    {
        //check if instance already exists
        if (instance == null)
        {
            instance = this;
        }
        //If not 
        else if (instance != this)
        {
            //Then, destroy this. This enforces our singleton pattern, meaning that there can only ever be one instance of a GameManager
            Destroy(gameObject);
        }

        //Don't destroy when reloading scene
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
		if (PhotonNetwork.IsConnectedAndReady)
        {
            object playerSelectionNumber;
            if (PhotonNetwork.LocalPlayer.CustomProperties.TryGetValue(MultiplayerRacingGame.PLAYER_SELECTION_NUMBER, out playerSelectionNumber ))
            {

                int actorNumber = PhotonNetwork.LocalPlayer.ActorNumber;

                // Create position
                Vector3 instantiatePosition = InstantiatePositions[actorNumber-1].position;

                PhotonNetwork.Instantiate(PlayerPrefabs[(int)playerSelectionNumber].name,instantiatePosition,Quaternion.Euler(0, 35, 0));
                carCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraFollowController>();
                carCamera.LookAtTarget = GameObject.Find("LookAtPos");
                carCamera.cameraPos = GameObject.Find("CameraPos");

                /*
                if ((int)playerSelectionNumber == 0)
                {
                    //Instantiate(blackCar);
                    Vector3 startingPos = startPos1.position;
                    //Instantiate(blackCar, startingPos);
                    PhotonNetwork.Instantiate(PlayerPrefabs[(int)playerSelectionNumber].name, startingPos, Quaternion.Euler(0, 40, 0));
                    carCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraFollowController>();
                    carCamera.LookAtTarget = GameObject.Find("LookAtPos");
                    carCamera.cameraPos = GameObject.Find("CameraPos");
                }

                else if ((int)playerSelectionNumber == 1)
                {
                    //Instantiate(yellowCar);
                    Vector3 startingPos = startPos2.position;
                    //PhotonNetwork.Instantiate(yellowCar, startingPos, Quaternion.Euler(0,40,0));
                    PhotonNetwork.Instantiate(PlayerPrefabs[(int)playerSelectionNumber].name, startingPos, Quaternion.Euler(0, 40, 0));
                    carCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraFollowController>();
                    carCamera.LookAtTarget = GameObject.Find("LookAtPos");
                    carCamera.cameraPos = GameObject.Find("CameraPos");

                }

                else if ((int)playerSelectionNumber == 2)
                {
                    //Instantiate(redCar);
                    Vector3 startingPos = startPos3.position;
                    PhotonNetwork.Instantiate(redCar, startPos3);

                    carCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraFollowController>();
                    carCamera.LookAtTarget = GameObject.Find("LookAtPos");
                    carCamera.cameraPos = GameObject.Find("CameraPos");

                }

                //if (PhotonNetwork.CurrentRoom.PlayerCount == 1)
                //{
                //    Instantiate(blackcar);
                //    camera.GetComponent<CameraFollowController>();
                //}
                */
            }
        }
		
		foreach (GameObject gm in FinishOrderUIGameObjects)
        {
            gm.SetActive(false);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log(PhotonNetwork.CurrentRoom.PlayerCount);
        //object playerSelectionNumber;
        //Debug.Log("NUMBER:" + PhotonNetwork.LocalPlayer.CustomProperties.TryGetValue(MultiplayerRacingGame.PLAYER_SELECTION_NUMBER, out playerSelectionNumber));
        //Debug.Log("number" + (int)playerSelectionNumber);
    }
    public void OnQuitMatchButtonClicked()
    {
        PhotonNetwork.LeaveRoom();
        PhotonNetwork.LoadLevel("LobbyScene");
    }

    /*public override void OnLeftRoom()
    {
        PhotonNetwork.LoadLevel("LobbyScene");
    }*/
}

