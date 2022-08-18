using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _input;
    private RotateToMouse _rotateToMouse;

    public float Speed = 3f;

    private void Awake()
    {
        _input = GetComponent<PlayerInput>();
        _rotateToMouse = GetComponent<RotateToMouse>();
    }

    private void Update()
    {
        Look();
        Move();
    }
    
    private void Move()
    {

        transform.Translate(new Vector3(_input.xPos, 0, _input.zPos) * Speed * Time.deltaTime);

    }

    private void Look()
    {
        _rotateToMouse.CameraRotate(_input.mouseUD);
        _rotateToMouse.CharacterRotate(_input.mouseLR);
    }
}
