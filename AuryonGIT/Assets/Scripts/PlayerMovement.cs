using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController2D controller;

    float horizontalMove = 0f;
    [SerializeField] float runSpeed = 40f;
    bool jump = false;
    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController2D>();
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }
}
