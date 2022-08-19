using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    private PlayerUI _playerUI;
    private PlayerInput _playerInput;

    [SerializeField]
    private float distance = 3f;
    [SerializeField]
    private LayerMask layer;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<RotateToMouse>().sight;
        _playerUI = GetComponent<PlayerUI>();
        _playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        _playerUI.UpdateText("");

        InteractableRay();
    }

    public void InteractableRay()
    {
        // ray생성
        Ray ray = new Ray(cam.transform.position, cam.transform.forward); // origin, direction
        Debug.DrawRay(ray.origin, ray.direction * distance);
        // 콜라이더 정보를 담을 Raycast필요
        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo, distance, layer))
        {
            if(hitInfo.collider.GetComponent<Interactable>() != null)
            {
                var interactable = hitInfo.collider.GetComponent<Interactable>();
                // 설정한 레이어마스크에 닿을시 실행할 구문
                
                _playerUI.UpdateText(hitInfo.collider.GetComponent<Interactable>().PromtMessage);

                if(_playerInput.interactKey == true)
                {
                    interactable.BaseInteract();

                }
            }
        }

    }

    
}
