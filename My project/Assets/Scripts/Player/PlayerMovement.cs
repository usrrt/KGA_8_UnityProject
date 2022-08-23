using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _input;
    private RotateToMouse _rotateToMouse;
    private CharacterController _controller;

    [SerializeField]
    private float Speed; 
    [SerializeField]
    private float gravity = 10f;

    private bool inventoryActivated = false;

    private void Awake()
    {
        _input = GetComponent<PlayerInput>();
        _rotateToMouse = GetComponent<RotateToMouse>();
        _controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if(_input.inventoryKey)
        {
            inventoryActivated = !inventoryActivated;
        }

        Look();
        Move();
    }
    
    private void Move()
    {

        Vector3 moveDir = transform.TransformDirection(new Vector3(_input.xPos, 0, _input.zPos) * Speed * Time.deltaTime);
        moveDir.y -= gravity;
        _controller.Move(moveDir);

    }

    private float yPos;
    private bool sitDown;

    private void Look()
    {
        if (inventoryActivated)
            return;

        if(_input.sitKey)
        {
            sitDown = !sitDown;
        }

        if(sitDown)
        {
            Speed = 1f;
            yPos -= Time.deltaTime * 10;
            if (yPos <= -0.5f)
                yPos = -0.5f;
        }
        else
        {
            Speed = 2.5f;
            yPos += Time.deltaTime * 10;
            if (yPos >= 0.9f)
                yPos = 0.9f;
        }

        _rotateToMouse.sight.transform.position = new Vector3(transform.position.x, transform.position.y + yPos, transform.position.z);
        _rotateToMouse.CameraRotate(_input.mouseUD);
        _rotateToMouse.CharacterRotate(_input.mouseLR);
    }

    
}
