using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class playOnClick : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip hover;
    public AudioClip click;

    public void hoverSound()
    {
        sound.PlayOneShot(hover);
    }
    public void clickSound()
    {
        sound.PlayOneShot(click);
    }
}
