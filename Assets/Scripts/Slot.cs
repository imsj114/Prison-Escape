using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class Slot : MonoBehaviour {
 
    public Item slot=null;    // 슬롯을 스택으로 만든다.
    private Image      ItemImg;
    private bool       isSlot;     // 현재 슬롯이 비어있는지?
    public bool isSlots()             { return isSlot;        } // 슬롯이 현재 비어있는지? 에 대한 플래그 반환.
    public void SetSlots(bool isSlot) { this.isSlot = isSlot; }
    
    void Start()
    {
 
        // 맨 처음엔 슬롯이 비어있다.
        isSlot = false;
 
        
 
        ItemImg = GetComponent<Image>();
        Debug.Log(ItemImg.ToString());
    }
 
    public void AddItem(Item item)
    {
        // 스택에 아이템 추가.
        slot=item;
        UpdateInfo(true, item.DefaultImg);
    }

 
    // 슬롯에 대한 각종 정보 업데이트.
    public void UpdateInfo(bool isSlot, Sprite sprite)
    {
        SetSlots(isSlot);
        Debug.Log(sprite.ToString());                                         // 슬롯이 비어있다면 false 아니면 true 셋팅.
        ItemImg.sprite = sprite;                                   // 슬롯안에 들어있는 아이템의 이미지를 셋팅.
                                   
    }
}
