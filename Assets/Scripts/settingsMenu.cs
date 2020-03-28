using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class settingsMenu : MonoBehaviour
{
    public AudioSource curr_music;
    public Slider vol;
    public Slider sound_vol;
    private GameObject[] buttons;

    private void Start()
    {
        if (buttons == null)
            buttons = GameObject.FindGameObjectsWithTag("buttons");
    }

    void Update()
    {
        curr_music.volume = vol.value;
        foreach (GameObject button in buttons)
        {
            button.GetComponent<AudioSource>().volume = sound_vol.value;
        }


    }

}
