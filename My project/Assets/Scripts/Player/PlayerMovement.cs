using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _input;
    private Rigidbody _rb;
    private RotateToMouse _rotateToMouse;

    public float Speed = 3f;

    private void Awake()
    {
        _input = GetComponent<PlayerInput>();
        _rb = GetComponent<Rigidbody>();
        _rotateToMouse = GetComponent<RotateToMouse>();
    }

    private void Update()
    {
        Look();
        Move();
    }
    
    private void Move()
    {
        Vector3 moveHorizontal = transform.right * _input.xPos;
        Vector3 moveVertical = transform.forward * _input.zPos;

        Vector3 velocity = (moveHorizontal + moveVertical).normalized * Speed;

        _rb.MovePosition(transform.position + velocity * Time.deltaTime);
    }

    private void Look()
    {
        _rotateToMouse.UpdateRotate(_input.mouseLR, _input.mouseUD);
    }
}
