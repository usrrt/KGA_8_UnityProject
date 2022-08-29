using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] Canvas _infoCanvas;

    private PlayerUI playerUI;

    private void Awake()
    {
        playerUI = GameObject.Find("Player").GetComponent<PlayerUI>();
    }
    public void Resume()
    {
        //gameObject.SetActive(false);
        playerUI.MenuActivated = false;
    }

    public void MainTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void ControlInfo()
    {
        _infoCanvas.sortingOrder = 10;
        _infoCanvas.enabled = true;
    }
}
