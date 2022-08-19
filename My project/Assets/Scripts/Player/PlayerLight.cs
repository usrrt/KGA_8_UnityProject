using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLight : MonoBehaviour
{
    private PlayerInput _input;
    [SerializeField]
    private GameObject _light;

    private bool flashLightEnable;

    public bool hasFlashLight;

    private void Awake()
    {
        _input = GetComponent<PlayerInput>();
    }

    private void Start()
    {
        _light.SetActive(false);

        hasFlashLight = false;
    }

    private void LateUpdate()
    {
        if(hasFlashLight)
        {
            if(_input.flashLightKey)
            {
                flashLightEnable = !flashLightEnable;
            }
        
            if(flashLightEnable)
            {
                _light.SetActive(flashLightEnable);
            }
            else
            {
                _light.SetActive(flashLightEnable);
            }
        }
    }

    // 추후 추가할 사항
    // 손전등아이템을 소지해야만 기능을 사용할수있다.
}
