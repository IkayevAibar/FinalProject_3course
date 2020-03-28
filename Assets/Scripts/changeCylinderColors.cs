using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCylinderColors : MonoBehaviour
{
    private GameObject[] objects;
    private Renderer rend;
    private float timer = 0f;
    private void Start()
    {
        Invoke("Initiate", 1f);

    }
    void Initiate()
    {
        objects = GameObject.FindGameObjectsWithTag("Enemy");
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2.0f)//change the float value here to change how long it takes to switch.
        {
            foreach (var obj in objects)
            {
                rend = obj.GetComponent<MeshRenderer>();
                Color newCol = new Color(Random.value, Random.value, Random.value);
                rend.material.color = newCol;
            }
            timer = 0;
        }
       
    }
}
