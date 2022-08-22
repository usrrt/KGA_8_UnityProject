using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartLightOff : MonoBehaviour
{
    [SerializeField]
    private GameObject lights;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        Debug.Log("check");
    //        lights.SetActive(false);
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            
            lights.SetActive(false);
        }
    }
}
