using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirDrop : MonoBehaviour
{
    public List<ItemData> ItemDatas;
   // public List<ItemData> ItemDatas2;
    //public Chest Chest;
    public Item Item;
    public float HalfWidth;
    private void Start()
    {
        for (int i = 0; i < ItemDatas.Count; i++)
        {
            Instantiate(Item, new Vector3(Random.Range(transform.position.x - HalfWidth, transform.position.x + HalfWidth), transform.position.y, transform.position.z), Quaternion.identity).Data = ItemDatas[i];
        }
    }  
}
