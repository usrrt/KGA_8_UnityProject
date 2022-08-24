using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinePuzzle : Interactable
{
    public delegate void ChainFuc();
    public static event ChainFuc Unlock;

    private Inventory _inven;
    private GameObject _prefab;

    public AudioSource _audio;
    public AudioClip _audioClip;

    private float wineRepositionAngle = -90f;
    private float wineRepositionZpos = -0.427f;

    private void Awake()
    {
        _inven = GameObject.Find("Inventory").GetComponent<Inventory>();

        PromtMessage = "와인 꽂기 [E]";

    }
    protected override void Interact()
    {
        // 플레이어가 와인병을 가지고있다면
        if (GameManager.Instance.playerHasWine)
        {
            for (int i = 0; i < _inven.slots.Length; i++)
            {
                if (_inven.slots[i] != null)
                {
                    if (_inven.slots[i].itemName == "WineBottleKey")
                    {
                        _prefab = _inven.slots[i].item.itemPrefab;
                    }
                }
            }
            _prefab.transform.rotation = Quaternion.Euler(wineRepositionAngle, 0, 0);
            Vector3 dis = new Vector3(0f, 0f, wineRepositionZpos);
            GameObject instance = Instantiate(_prefab, transform.position - dis, _prefab.transform.rotation);

            GameManager.Instance.playerHasWine = false;

            _inven.UseItem("WineBottleKey");


            // 맞는 위치일시 문이 열린다.
            if (gameObject.CompareTag("PuzzleAnswer"))
            {
                _audio.PlayOneShot(_audioClip);
                Unlock();
            }
                
        }

        
    }
}
