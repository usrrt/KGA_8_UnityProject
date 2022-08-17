using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float xPos { get; private set; }
    public float zPos { get; private set; }
    public float mouseLR { get; private set; }
    public float mouseUD { get; private set; }

    private void Awake()
    {
        // 마우스 커서가 보이지 않게 설정하기
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        xPos = Input.GetAxis("Horizontal");
        zPos = Input.GetAxis("Vertical");

        mouseLR = Input.GetAxis("Mouse X");
        mouseUD = Input.GetAxis("Mouse Y");
    }

}
