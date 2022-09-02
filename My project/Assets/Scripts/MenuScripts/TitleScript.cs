using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
    }

    [SerializeField] Canvas _infoCanvas;
    public void StartGame()
    {
        
        SceneManager.LoadScene("GameScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Info()
    {
        _infoCanvas.enabled = true;

        _infoCanvas.sortingOrder = 10;  
    }
}
