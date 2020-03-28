using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Experimental.Input;

public class GameController : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject winner;
    public int finisher;
    public Text pause;
    public Text win;
    public Image panel;
    public Button restart;
    public Button back;
    public Button next;
    public float sbf1 = 0;
    public float sbf2 = 0;
    public bool isFinished;
    public bool isSolo;
    public GameObject pl;
    public Player pll;
    public float b1;
    public float b2;
    bool endByFinish;
    public void StartSingle()
    {
        pl.GetComponent<Player>().SetSolo(true);
        isSolo = true;
        pl.GetComponent<Player>().SavePlayer();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
    public void StartMulti()
    {
        pl.GetComponent<Player>().SetSolo(false);
        isSolo = false;
        pl.GetComponent<Player>().SavePlayer();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void Restart()
    {
        SceneManager.LoadScene(3);
    }
    public void Next()
    {
        
        SceneManager.LoadScene(4);
    }
    public void LoadEnd()
    {
        if (finisher == 1)
        {
            winner = Player1;
        }
        else if (finisher == 2)
        {
            winner = Player2;
        }
        panel.gameObject.SetActive(!panel.gameObject.activeSelf);
        restart.gameObject.SetActive(!restart.gameObject.activeSelf);
        back.gameObject.SetActive(!back.gameObject.activeSelf);
        win.gameObject.SetActive(!win.gameObject.activeSelf);
        PlayerData pdd = SaveSystem.LoadPlayer();
        if(finisher == 1) { 
            win.text += winner.GetComponent<Player1>().nickname;
        }
        else
        {
            Debug.Log(pdd.isSolo);
            if (pdd.isSolo==true)
            {
                win.text ="Game Over, " + Player1.GetComponent<Player1>().nickname;
            }
            else
                win.text += winner.name;
        }
        isFinished = true;
        if (endByFinish == true)
        {
            next.gameObject.SetActive(true);
        }
    }
    public IEnumerator sec(int a) {
        yield return new WaitForSecondsRealtime(a);
    }
    private void FixedUpdate()
    {
        
        Keyboard kb = InputSystem.GetDevice<Keyboard>();
        if (kb.escapeKey.wasPressedThisFrame && isFinished== false)
        {
            
            panel.gameObject.SetActive(!panel.gameObject.activeSelf);
            pause.gameObject.SetActive(!pause.gameObject.activeSelf);
            restart.gameObject.SetActive(!restart.gameObject.activeSelf);
            back.gameObject.SetActive(!back.gameObject.activeSelf);
            
            if (panel.gameObject.activeSelf == true)
            {
                b1 = Player1.GetComponent<Player1>().speed;
                b2 = Player2.GetComponent<Player2>().speed;
                Player1.GetComponent<Player1>().speed = 0;
                Player2.GetComponent<Player2>().speed = 0;
            }
            else
            {
                Player1.GetComponent<Player1>().speed = b1;
                Player2.GetComponent<Player2>().speed = b2;
            }
            
        }
        
    }
    public void GameEnded(int a, bool b)
    {
        endByFinish = b;
        finisher = a;
        Player1.GetComponent<Player1>().speed = 0;
        Player2.GetComponent<Player2>().speed = 0;
        Debug.Log(finisher);
        StartCoroutine(sec(3));
        LoadEnd();


    }
}
