using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerMove : MonoBehaviour
{
    private CharacterController characterController;

    private float gravity = 10f;
    // Update is called once per frame
    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        float xPos = Input.GetAxis("Horizontal");
        float zPos = Input.GetAxis("Vertical");

        Vector3 moveDir = transform.TransformDirection(new Vector3(xPos, 0, zPos) * 2f * Time.deltaTime);
        moveDir.y -= gravity;
        characterController.Move(moveDir);
    }
}
