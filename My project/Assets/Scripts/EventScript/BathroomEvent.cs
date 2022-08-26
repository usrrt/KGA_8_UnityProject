using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathroomEvent : MonoBehaviour
{
    [SerializeField] Light _light;
    public GameObject dollObj;

    private void Start()
    {
        //_light.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(JumpScare());
        }

    }

    IEnumerator JumpScare()
    {
        _light.enabled = false;
        yield return new WaitForSeconds(.3f);
        dollObj.SetActive(false);
        _light.enabled = true;
        // 트리거도 사라짐
        //StopCoroutine(JumpScare());
        gameObject.SetActive(false);

    }

}
