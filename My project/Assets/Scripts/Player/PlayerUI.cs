using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PlayerUI : MonoBehaviour
{
    public GameObject Menu;

    [SerializeField]
    private TextMeshProUGUI _promtText;

    private PlayerInput _input;

    public bool MenuActivated;


    private void Awake()
    {
        _input = GetComponent<PlayerInput>();   
    }

    private void Start()
    {
        MenuActivated = false;
        Menu.SetActive(false);
    }

    private void Update()
    {
        if(_input.menuKey)
        {
            MenuActivated = !MenuActivated;
        }
        
        TryMenuUI();
    }

    private void TryMenuUI()
    {
        if(MenuActivated)
        {
            OpenMenuUI();
        }
        else
        {
            CloseMenuUI();
        }
    }

    private void OpenMenuUI()
    {
        // �޴�â ��
        Menu.SetActive(MenuActivated);
        // �ٸ� UI��
        // ���콺 Ŀ������
        Cursor.visible = true;

    }

    public void CloseMenuUI()
    {
        // �޴�â ��
        Menu.SetActive(MenuActivated);
        // �ٸ� UI��
        // ���콺Ŀ���Ⱥ���
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;

    }

    public void UpdateText(string promtStr)
    {
        _promtText.text = promtStr;
    }
}
