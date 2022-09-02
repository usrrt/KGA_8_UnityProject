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

    protected override void Interact()
    {
        if(GameManager.Instance.playerHasKnife)
        {
            // Ä®¼ÒÁö½Ã
            Debug.Log("3¹ø Âî¸§");
            GameManager.Instance.KnifeEnding = true;
            SceneManager.LoadScene("KnifeEnding");

        }
        else
        {
            // Ä®¾øÀ»½Ã
            Debug.Log("Ä®ÀÌ ¾ø¾î ³ª Á×¾î¹ö¸±°Å¾ß");
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
