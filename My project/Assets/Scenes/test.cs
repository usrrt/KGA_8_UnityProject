using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Points colliding: " + collision.contacts.Length);

        Debug.Log("Normal of the first point: " + collision.contacts[0].normal);

        foreach (var item in collision.contacts)
        {
            Debug.DrawRay(item.point, item.normal * 100, Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f), 10f);
        }
    }
}
