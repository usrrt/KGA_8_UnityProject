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
            PromtMessage = "Ä®·Î Âî¸¥´Ù";
        }
        else
        {
            PromtMessage = "Ã£¾Ò´Ù!";
        }
    }

    float elapsedTime;
    protected override void Interact()
    {
        elapsedTime = Time.time;
        if(GameManager.Instance.playerHasKnife)
        {
            // Ä®¼ÒÁö½Ã
            Debug.Log("3¹ø Âî¸§");
            GameManager.Instance.KnifeEnding = true;
            if(elapsedTime >= 1f)
            {
                SceneManager.LoadScene("TitleScene");
            }

        }
        else
        {
            // Ä®¾øÀ»½Ã
            animator.SetBool("Waking", true);
            Debug.Log("Ä®ÀÌ ¾ø¾î ³ª Á×¾î¹ö¸±°Å¾ß");
            GameManager.Instance.DeathEnding = true;
            if (elapsedTime >= 1.7f)
            {
                SceneManager.LoadScene("TitleScene");
            }
        }
    }
}
