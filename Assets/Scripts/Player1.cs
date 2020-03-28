using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

public class Player1 : MonoBehaviour
{
    public Asdasd ctrl;
    Rigidbody rb;
    public float speed ;
    Vector3 moveAxis;
    public GameController gc;
    public int gold= 0;
    public int skin_id = 0;
    public string nickname = "Player1";
    PlayerData pd;
    Material material;
    public bool isImmune = false;
    private void Awake()
    {
        speed = 10f;
        pd = SaveSystem.LoadPlayer();
        Debug.Log(pd.isSolo);
        if (pd != null) { 
            gold = pd.gold;
            nickname = pd.nickname;
            skin_id = pd.skin_id;
            if (pd.isSolo)
                gc.Player2.gameObject.SetActive(false);
            else
                gc.Player2.gameObject.SetActive(true);
        }
        MeshRenderer gameObjectRenderer = GetComponent<MeshRenderer>();

        material = gameObjectRenderer.material;
        if (skin_id == 0) {
            material.color = new Color(0.8584906f, 0.1579299f, 0.1579299f);
        }
        else if (skin_id == 1)
        {
            material.color = new Color(0.8877979f, 0.8962264f, 0.1479619f);
        }
        else if (skin_id == 2)
        {
            material.color = new Color(0.1490196f, 0.8902221f, 0.8980392f);
        }
        else
        {
            material.color = new Color(1f, 1f, 1f);
        }
        gameObjectRenderer.material = material;

        rb = GetComponent<Rigidbody>();
        
        ctrl.Player.Shoot.performed += ctx => Shoot();
        ctrl.Player.Movement.performed += ctx => Move(ctx.ReadValue<Vector2>());
    }
    private void FixedUpdate()
    {
        rb.transform.position += moveAxis * speed * Time.deltaTime;

    }
    public void Shoot()
    {
        Debug.Log("Shoot");
    }
    public void Move(Vector2 dir)
    {
        moveAxis = new Vector3(dir.x , 0, 1);
        
    }
    private void OnEnable()
    {
        ctrl.Enable();
    }
    private void OnDisable()
    {
        ctrl.Disable();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            gc.GameEnded(1,true);
        }
        else if(other.tag == "Enemy" && isImmune==false)
        {
            gc.GameEnded(2,false);
        }
    }
}
