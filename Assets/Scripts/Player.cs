using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public Transform groundCheckTransform = null;
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody rigidbodyComponent;
    [SerializeField] private LayerMask playerMask;
    public float speed = 5.0f;
    public Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //horizontalInput=Input.GetAxis("Horizontal");
        //verticalInput = Input.GetAxis("Vertical");
        movement = new Vector3(Input.GetAxis("Horizontal"), -1, Input.GetAxis("Vertical"));
    }
    //Called once every physics update
    void FixedUpdate()
    {
        //rigidbodyComponent.velocity=new Vector3(horizontalInput, rigidbodyComponent.velocity.y, 0);
        //rigidbodyComponent.velocity=new Vector3(0, rigidbodyComponent.velocity.y, verticalInput);
        moveCharacter(movement);
    }

    void moveCharacter(Vector3 direction)
    {
        rigidbodyComponent.velocity = direction * speed;
    }
}
