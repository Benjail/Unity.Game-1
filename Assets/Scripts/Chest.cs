using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public ItemData Data;
    public Item Item;
    public void Open()
    {
       // Debug.Log("Сундук открыт");
        Instantiate(Item, transform.position, Quaternion.identity).Data = Data;     
        Destroy(gameObject);                                            
    }
    private void Start()
    {
        
    }
}
