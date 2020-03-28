using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateCube : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public GameObject cube;
    public Dropdown dropdown;
    
    void Update()
    {
        //Debug.Log(dropdown.value + " " + dropdown.options[dropdown.value].text);
        if(dropdown.value==0)
        {
            cube.GetComponent<MeshRenderer>().material.color = new Color(0.8584906f, 0.1579299f, 0.1579299f);
        }
        else if (dropdown.value == 1)
        {
            cube.GetComponent<MeshRenderer>().material.color = new Color(0.8877979f, 0.8962264f, 0.1479619f);
        }
        else if (dropdown.value == 2)
        {
            cube.GetComponent<MeshRenderer>().material.color = new Color(0.1490196f, 0.8902221f, 0.8980392f);
        }
        cube.transform.rotation =new Quaternion(cube.transform.rotation.x, (cube.transform.rotation.y + 1f) * -slider.value , cube.transform.rotation.z, cube.transform.rotation.w) ;
    }

}
