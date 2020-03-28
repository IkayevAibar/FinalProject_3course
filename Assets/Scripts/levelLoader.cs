using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour
{
    public Slider slider;
    public GameObject loadingScreenObj;
    AsyncOperation operation;

    public void loadGame(int lvl)
    {
        StartCoroutine(loadAsyn(lvl));

    }
    IEnumerator loadAsyn(int Lvl)
    {
        loadingScreenObj.SetActive(true);
        operation = SceneManager.LoadSceneAsync(Lvl);
        operation.allowSceneActivation = false;
        while(operation.isDone == false)
        {
            slider.value = operation.progress;
            if(operation.progress == 0.9f)
            {
                slider.value = 1f;
                operation.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
