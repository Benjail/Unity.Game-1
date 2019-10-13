using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirDrop : MonoBehaviour
{
    public List<ItemData> ItemDatas; 
    public Chest Chest;
    public float HalfWidth;
    private void Start()
    {
        for (int i = 0; i < ItemDatas.Count; i++)
        {
            Instantiate(Chest,new Vector3(Random.Range(transform.position.x-HalfWidth, transform.position.x+HalfWidth),transform.position.y, transform.position.z),Quaternion.identity).Data=ItemDatas[i];
        }
    }  
}
