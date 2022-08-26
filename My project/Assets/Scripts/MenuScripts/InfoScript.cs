using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoScript : MonoBehaviour
{

    [SerializeField] Canvas _infoCanvas;
    public void Return()
    {
        _infoCanvas.sortingOrder = -10;
        _infoCanvas.enabled = false;
    }
}
