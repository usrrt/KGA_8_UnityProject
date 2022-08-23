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
        _playerUI.UpdateText(""); // ���� ����� ��ĭ���� ����

        InteractableRay();
    }

    public void InteractableRay()
    {
        // ray����
        Ray ray = new Ray(cam.transform.position, cam.transform.forward); // origin, direction
        Debug.DrawRay(ray.origin, ray.direction * distance);
        // �ݶ��̴� ������ ���� Raycast�ʿ�
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, distance, layer))
        {

            if (hitInfo.collider.GetComponent<Interactable>() != null)
            {

                var interactable = hitInfo.collider.GetComponent<Interactable>();
                // ������ ���̾��ũ�� ������ ������ ����

                if (_playerInput.interactKey == true)
                {
                    interactable.BaseInteract();

                    // Item�±׸� ���� ��ü�� �κ��丮�� �����Ѵ�.
                    if (hitInfo.collider.tag == "Item")
                    {
                        _inventory.AcquireItem(hitInfo.collider.GetComponent<ItemPickUp>().item);
                    }

                }
                else
                {
                    // �ؽ�Ʈ ���°�
                    _playerUI.UpdateText(interactable.PromtMessage);
                }








            }
        }

    }


}
