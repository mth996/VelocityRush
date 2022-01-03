using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningCutscene : MonoBehaviour
{
    public GameObject winningcutscene;
    //public GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {
        winningcutscene.SetActive(true);
        StartCoroutine(FinishwinCutscene());
    }

    // Update is called once per frame
    IEnumerator FinishwinCutscene()
    {
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene("LobbyScene");
    }
}