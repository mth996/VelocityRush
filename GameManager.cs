using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class GameManager : MonoBehaviour
{
    public void WinGame()
    {
        //Debug.Log("Game Over");
        //SceneManager.LoadScene("Winning");
        PhotonNetwork.LoadLevel("Winning");
    }
}
