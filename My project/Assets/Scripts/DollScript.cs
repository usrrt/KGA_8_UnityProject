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

    protected override void Interact()
    {
        if(GameManager.Instance.playerHasKnife)
        {
            // Į������
            Debug.Log("3�� �");
            GameManager.Instance.KnifeEnding = true;
            SceneManager.LoadScene("KnifeEnding");

        }
        else
        {
            // Į������
            Debug.Log("Į�� ���� �� �׾�����ž�");
            GameManager.Instance.DeathEnding = true;
            StartCoroutine(SceneLoadDelay());
        }
    }

    IEnumerator SceneLoadDelay()
    {
        animator.SetBool("Waking", true);
        yield return new WaitForSeconds(1.5f);
        GameManager.Instance.playerDie = true;
    }
}
