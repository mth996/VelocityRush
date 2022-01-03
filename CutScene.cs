using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour
{
    public GameObject cutscene;
    public GameObject Canvas;

    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) == true)
        {
            {
                SceneManager.LoadScene("LobbyScene");
            }
        }

    }
    void Start()
    {
        cutscene.SetActive(true);
        StartCoroutine(FinishCutscene());
    }
        
// Update is called once per frame
IEnumerator FinishCutscene()
    {
        yield return new WaitForSeconds(31);
        Canvas.SetActive(true);
        StartCoroutine(Finishscene());
    }

    IEnumerator Finishscene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("LobbyScene");
    }
}
