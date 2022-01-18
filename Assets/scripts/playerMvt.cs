using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMvt : MonoBehaviour
{
    float x=0, y=0;
    CharacterController controller;
    [SerializeField] float speed,gravitySpeed,gravityForce;
    [SerializeField] float gravity;
    [SerializeField] LayerMask groundLayer;
    bool isJumping = false;
    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        x = Input.GetAxis("Vertical");
        y = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            isJumping = true;
            gravity = gravityForce;
        }


        if (!Physics.Raycast(transform.position, transform.up * -1f, 2) && gravity != 0)
        {
            gravity -= 0.5f*(2f * Time.deltaTime) ;
            isJumping = false;
        }
        


    }


    private void FixedUpdate()
    {
    
            controller.Move((transform.forward * x + transform.right * y) * speed * Time.deltaTime + transform.up*gravity* gravitySpeed);
    }
}

