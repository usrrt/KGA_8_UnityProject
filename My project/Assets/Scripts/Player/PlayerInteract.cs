using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    private PlayerUI _playerUI;

    [SerializeField]
    private float distance = 3f;
    [SerializeField]
    private LayerMask layer;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<RotateToMouse>().sight;
        _playerUI = GetComponent<PlayerUI>();
    }

    // Update is called once per frame
    void Update()
    {
        _playerUI.UpdateText(string.Empty);
        // ray����
        Ray ray = new Ray(cam.transform.position, cam.transform.forward); // origin, direction
        Debug.DrawRay(ray.origin, ray.direction * distance);
        // �ݶ��̴� ������ ���� Raycast�ʿ�
        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo, distance, layer))
        {
            // ������ ���̾��ũ�� ������ ������ ����
            //Debug.Log(hitInfo.collider.GetComponent<Interactable>().PromtMessage);
            _playerUI.UpdateText(hitInfo.collider.GetComponent<Interactable>().PromtMessage);
        }
    }
}
