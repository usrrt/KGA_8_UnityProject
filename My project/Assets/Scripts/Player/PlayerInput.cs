using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float xPos { get; private set; }
    public float zPos { get; private set; }
    public float mouseLR { get; private set; }
    public float mouseUD { get; private set; }
    public bool interactKey { get; private set; }
    public bool flashLightKey { get; private set; }
    public bool inventoryKey { get; private set; }
    public bool sitKey { get; private set; }
    public bool menuKey { get; private set; }

    private void Awake()
    {
        // 마우스 커서가 보이지 않게 설정하기
        Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
        Cursor.lockState = CursorLockMode.Confined;
    }

    private void Update()
    {
        xPos = Input.GetAxis("Horizontal");
        zPos = Input.GetAxis("Vertical");

        mouseLR = Input.GetAxisRaw("Mouse X");
        mouseUD = Input.GetAxisRaw("Mouse Y");

        interactKey = Input.GetKeyDown(KeyCode.E);

        flashLightKey = Input.GetKeyDown(KeyCode.F);

        inventoryKey = Input.GetKeyDown(KeyCode.I);

        sitKey = Input.GetKeyDown(KeyCode.C);

        menuKey = Input.GetKeyDown(KeyCode.Escape);
    }

}
