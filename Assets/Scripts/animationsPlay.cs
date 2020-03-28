using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationsPlay : MonoBehaviour
{

    private float count = 0;
    // Start is called before the first frame update
    void Start()
    {
        count = count + Time.deltaTime;
        if(count < 5)
        {
            GetComponent<Animation>().Play("ship_animation");


        }
        else
        {
            GetComponent<Animation>().Stop("ship_animation");

            GetComponent<Animation>().Play("ship_bouncing");
        }


    }

    // Update is called once per frame
    void Update()
    { 

    }
}
