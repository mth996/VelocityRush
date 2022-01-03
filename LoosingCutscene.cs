using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoosingCutscene : MonoBehaviour
{
    public GameObject Loosingcutscene;
    //public GameObject Canvas;

    // Start is called before the first frame update
   
    void Start()
    {
        Loosingcutscene.SetActive(true);
        StartCoroutine(FinishLooseCutscene());
    }

    // Update is called once per frame
    IEnumerator FinishLooseCutscene()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("LobbyScene");
    }
}

