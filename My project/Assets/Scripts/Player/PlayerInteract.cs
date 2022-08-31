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
    [SerializeField]
    private Inventory _inventory;

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
        _playerUI.UpdateText(""); // 래이 벗어나면 빈칸으로 만듬

        InteractableRay();
    }

    RaycastHit hitInfo;
    Ray ray;
    public void InteractableRay()
    {
        ray = new Ray(cam.transform.position, cam.transform.forward);

        if (Physics.Raycast(ray, out hitInfo, distance, layer))
        {
            if (hitInfo.collider.GetComponent<Interactable>() != null)
            {
                OnInteract();
            }
        }
    }

    private void OnInteract()
    {
        var interactable = hitInfo.collider.GetComponent<Interactable>();
        _playerUI.UpdateText(interactable.PromtMessage);

        // 설정한 레이어마스크에 닿을시 실행할 구문
        if (_playerInput.interactKey == true)
        {
            interactable.BaseInteract();

            // Item태그를 가진 객체만 인벤토리에 저장한다.
            if (hitInfo.collider.tag == "Item")
            {
                _inventory.AcquireItem(hitInfo.collider.GetComponent<ItemPickUp>().item);
            }

            

        }
    }
}
