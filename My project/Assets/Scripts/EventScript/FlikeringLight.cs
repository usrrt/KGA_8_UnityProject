using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlikeringLight : MonoBehaviour
{
    // ÀüµîÀÌ ±ôºý°Å¸°´Ù
    private Light _light;

    public float minNum;
    public float maxNum;
    public float Delay;

    private void Awake()
    {
        _light = GetComponent<Light>();
    }

    private void Start()
    {
        _light.enabled = false;
        IsFlikering = true;
    }

    private void Update()
    {
        if (GameManager.Instance.playerHasKey)
        {
            StartCoroutine(Flikering());

        }
    }

    bool IsFlikering;
    IEnumerator Flikering()
    {
        while(IsFlikering)
        {
            IsFlikering=false;
            Delay = Random.Range(minNum, maxNum);
            _light.enabled = !_light.enabled;
            yield return new WaitForSeconds(Delay);
            _light.enabled = !_light.enabled;
            Delay = Random.Range(minNum, maxNum);
            yield return new WaitForSeconds(Delay);
            IsFlikering= true;
        }
    }
}
