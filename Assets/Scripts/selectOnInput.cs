using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class selectOnInput : MonoBehaviour
{
    public EventSystem eventSystems;
    public GameObject selectedObject;
    private bool selected;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Vertical") != 0 && selected == false)
        {
            eventSystems.SetSelectedGameObject(selectedObject);
            selected = true;
        }
    }
    public void Shop()
    {
        SceneManager.LoadScene(2);
    }
    private void OnDisable()
    {
        selected = false;
    }
}
