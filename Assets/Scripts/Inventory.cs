using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Inventory : MonoBehaviour
{
 
    // 공개
    public List<GameObject> AllSlot;    // 모든 슬롯을 관리해줄 리스트.
    public RectTransform InvenRect;     // 인벤토리의 Rect
    public GameObject OriginSlot;       // 오리지널 슬롯.

    
 
    public float slotSize;              // 슬롯의 사이즈.
    public float slotGap;               // 슬롯간 간격.
    public float slotCountX;            // 슬롯의 가로 개수.
    public float slotCountY;            // 슬롯의 세로 개수.

    public int itemNum;                 //현재 있는 아이템의 개수 
 
    // 비공개.
    private float InvenWidth;           // 인벤토리 가로길이.
    private float InvenHeight;          // 인밴토리 세로길이.
    private int EmptySlot;            // 빈 슬롯의 개수.
 
    void Awake()
    {
         foreach (Transform child in transform)
        {
            
            //child is your child transform
            AllSlot.Add(child.gameObject);
            
        }

         EmptySlot = AllSlot.Count;
         itemNum=0;
    }
 
    // 아이템을 넣기위해 모든 슬롯을 검사.
    public bool AddItem(Item item)
    {
        // 슬롯의 총 개수.
        int slotCount = AllSlot.Count;
      //현재 채워져 있는 슬롯의 숫자
      if( AllSlot.Count >= itemNum)
            itemNum=itemNum+1;
    

      for (int i = itemNum-1;  i< itemNum; i++){
            // 그 슬롯의 스크립트를 가져온다.
            Slot slot = AllSlot[i].GetComponent<Slot>();
            slot.AddItem(item);
    }
       return true;
    }
}