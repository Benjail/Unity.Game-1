using System.Collections;   
using System.Collections.Generic;  
using UnityEngine;

public class AirDrop : MonoBehaviour 
{
    [SerializeField] private int ItemsCount;
    [SerializeField] private GameObject _barrierPrefab; 
    [SerializeField] private float _halfWidth;  
    [SerializeField] private GameObject _item;
    private int RandItemsCount() 
    {
        int i= UnityEngine.Random.Range(0, 10); 
        return i;
    }
    public int GetItemsCount() 
    {
        return ItemsCount; 
    }
    public void InstantiateObject(GameObject gameObject)
    {
        Instantiate(gameObject, new Vector3(UnityEngine.Random.Range(transform.position.x - _halfWidth, transform.position.x + _halfWidth), transform.position.y, transform.position.z), Quaternion.identity);
    }
   private void Start()  
    {
        ItemsCount = RandItemsCount();  
        for (int i = 0; i < ItemsCount; i++)  
        { 
            InstantiateObject(_item);
            InstantiateObject(_barrierPrefab);
        }
    }   
} 
