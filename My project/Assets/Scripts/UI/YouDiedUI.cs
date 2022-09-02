using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class YouDiedUI : MonoBehaviour
{
    [SerializeField] GameObject _UI;

    void Start()
    {
        _UI.SetActive(false);
        
    }

    void Update()
    {
        if (GameManager.Instance.playerDie)
        {
            Cursor.visible = true;
            _UI.SetActive(true);
        }
    }

}
