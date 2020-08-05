using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Inventory : MonoBehaviour
{
 
    // 공개
    public List<GameObject> AllSlot;    // 모든 슬롯을 관리해줄 리스트.

    public int itemNum;                 //현재 있는 아이템의 개수 
 
    // 비공개.
    private int EmptySlot;            // 빈 슬롯의 개수.
    private GameManager gameManager;
    private static Inventory m_instance;
    public static Inventory instance{
        get {
            if(m_instance == null){
                m_instance = FindObjectOfType<Inventory>();
            }
            return m_instance;
        }
    }
    void Awake()
    {
        if(instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gameManager = GameManager.instance;
            foreach (Transform child in transform)
            {
                //child is your child transform
                AllSlot.Add(child.gameObject);
            }
            EmptySlot = AllSlot.Count;
            itemNum=0;
            DontDestroyOnLoad(transform.root.gameObject);
        }
        
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