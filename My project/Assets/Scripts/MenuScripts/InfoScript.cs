using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoScript : MonoBehaviour
{
    public void Return()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
