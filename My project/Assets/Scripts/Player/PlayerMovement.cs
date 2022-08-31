using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _input;
    private RotateToMouse _rotateToMouse;
    private CharacterController _controller;
    private PlayerUI _playerUI;
    
    private float Speed; 
    private float gravity = 10f;

    private void Awake()
    {
        _input = GetComponent<PlayerInput>();
        _rotateToMouse = GetComponent<RotateToMouse>();
        _controller = GetComponent<CharacterController>();
        _playerUI = GetComponent<PlayerUI>();
    }

    private void Update()
    {
        Look();
        Move();
    }
    
    private void Move()
    {
        PlayerSit();

        Vector3 moveDir = transform.TransformDirection(new Vector3(_input.xPos, 0, _input.zPos) * Speed * Time.deltaTime);
        moveDir.y -= gravity;
        _controller.Move(moveDir);
    }

    private float yPos;
    private bool sitDown;

    private void Look()
    {
        if (Inventory.inventoryActivated)
            return;
        if (GameManager.Instance.KeyPadActivated)
            return;
        if (_playerUI.MenuActivated)
            return;

        _rotateToMouse.sight.transform.position = new Vector3(transform.position.x, transform.position.y + yPos, transform.position.z);
        _rotateToMouse.CameraRotate(_input.mouseUD);
        _rotateToMouse.CharacterRotate(_input.mouseLR);
    }

    private void PlayerSit()
    {
        if (_input.sitKey)
        {
            sitDown = !sitDown;
        }

        if (sitDown)
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
    }
}
