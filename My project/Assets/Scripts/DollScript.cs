using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DollScript : Interactable
{
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void LateUpdate()
    {
        if(GameManager.Instance.playerHasKnife)
        {
            PromtMessage = "Į�� ���";
        }
        else
        {
            PromtMessage = "ã�Ҵ�!";
        }
    }

    float elapsedTime;
    protected override void Interact()
    {
        elapsedTime = Time.time;
        if(GameManager.Instance.playerHasKnife)
        {
            // Į������
            Debug.Log("3�� �");
            GameManager.Instance.KnifeEnding = true;
            if(elapsedTime >= 1f)
            {
                SceneManager.LoadScene("TitleScene");
            }

        }
        else
        {
            // Į������
            animator.SetBool("Waking", true);
            Debug.Log("Į�� ���� �� �׾�����ž�");
            GameManager.Instance.DeathEnding = true;
            if (elapsedTime >= 1.7f)
            {
                SceneManager.LoadScene("TitleScene");
            }
        }
    }
}
