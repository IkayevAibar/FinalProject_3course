using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonus : MonoBehaviour
{
    int nrand;
    public GameObject p1;
    public GameObject p2;
    Collider _col;
    public IEnumerator Sec2()
    {
        yield return new WaitForSeconds(3);
        

    }
    public void SetNorm()
    {
        if (_col != null) { 
            if (nrand == 0 || nrand == 1)
            {
                if (_col.gameObject.tag == "Player1")
                {
                    _col.gameObject.GetComponent<Player1>().speed = 5f;
                }
                else { 
                    _col.gameObject.GetComponent<Player2>().speed = 5f;
                }
            }
            else if (nrand == 2)
            {
                if (_col.gameObject.tag == "Player1")
                    _col.gameObject.GetComponent<Player1>().isImmune = false;
                else
                    _col.gameObject.GetComponent<Player2>().isImmune = false;
            }
            else if (nrand == 3)
            {
                if (_col.gameObject.tag == "Player1")
                    p2.GetComponent<Player2>().speed = 5f;
                else
                    p1.GetComponent<Player1>().speed = 5f;
            }
        }
    }
    public void Apply(Collider col)
    {
        PlayerData pdd = SaveSystem.LoadPlayer();
        
        _col = col;
        Dictionary<int, string> d = new Dictionary<int, string>
        {
            { 0, "Speed" },
            { 1, "Slow" },
            { 2, "immune" },
            { 3, "OppSlow" },
        };
        if (pdd.isSolo == false)
        {
            nrand = Random.Range(0, 4);
            
            if (nrand == 0)
            {
                if (col.gameObject.tag == "Player1")
                {
                    col.gameObject.GetComponent<Player1>().speed += 2f;
                }
                else
                    col.gameObject.GetComponent<Player2>().speed += 2f;
            }
            else if (nrand == 1)
            {
                if (col.gameObject.tag == "Player1")
                    col.gameObject.GetComponent<Player1>().speed -= 2f;
                else
                    col.gameObject.GetComponent<Player2>().speed -= 2f;
            }
            else if (nrand == 2)
            {
                if (col.gameObject.tag == "Player1")
                    col.gameObject.GetComponent<Player1>().isImmune = true;
                else
                    col.gameObject.GetComponent<Player2>().isImmune = true;
            }
            else if (nrand == 3)
            {
                if (col.gameObject.tag == "Player1")
                    p2.GetComponent<Player2>().speed = 4f;
                else
                    p1.GetComponent<Player1>().speed = 4f;
            }
            Invoke("SetNorm", 2f);
            
        }
        else
        {
            Debug.Log(col.name);
            if(col.name=="Player")
            pdd.gold += 1;
            SaveSystem.SavePlayer(new Player(pdd));
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player1" || other.gameObject.tag == "Player2")
        {
            Apply(other);
            GameObject self = GetComponent<SphereCollider>().gameObject;
            Destroy(self);
        }
    }
}
    
