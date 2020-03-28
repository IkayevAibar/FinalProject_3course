using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    Vector3 offset;
    public GameObject player;
    public GameObject player2;

    // Start is called before the first frame update
    void Start()
    {
        if(player2.activeSelf==true)
            offset = transform.position - (player.transform.position + player2.transform.position)/2; 
        else
            offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (player2.activeSelf == true)
            transform.position = (player.transform.position + player2.transform.position) / 2 + offset;
        else
            transform.position = player.transform.position + offset;
    }
}
