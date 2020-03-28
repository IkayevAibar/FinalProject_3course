using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

public class Player2 : MonoBehaviour
{
    public Asdasd ctrl;
    Rigidbody rb;
    public float speed;
    Vector3 moveAxis;
    public GameController gc;
    public bool isImmune;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        speed = 10f;
        ctrl.Player2.Shoot.performed += ctx => Shoot();
        ctrl.Player2.Movement.performed += ctx => Move(ctx.ReadValue<Vector2>());
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
        moveAxis = new Vector3(dir.x, 0, 1);
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
            gc.GameEnded(1, true);
        }
        else if (other.tag == "Enemy" && isImmune == false)
        {
            gc.GameEnded(2, false);
        }
    }
}
