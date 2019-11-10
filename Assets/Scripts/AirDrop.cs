using System.Collections;   
using System.Collections.Generic;  
using UnityEngine;
using System;

public class AirDrop : MonoBehaviour 
{    
    public int ItemsCount { get; private set; }
    [SerializeField] private GameObject _barrier; 
    [SerializeField] private float _halfWidth; 
    [SerializeField] private GameObject _item; 
    private int _itemsCountrand()
    {
        System.Random rnd = new System.Random();
        int i;
        return  i= rnd.Next(0,10);
    }
    void Start()  
    {
        ItemsCount = _itemsCountrand();
        for (int i = 0; i < ItemsCount; i++)  
        { 
            Instantiate(_item, new Vector3(UnityEngine.Random.Range(transform.position.x - _halfWidth, transform.position.x + _halfWidth), transform.position.y, transform.position.z), Quaternion.identity);
            Instantiate(_barrier, new Vector3(UnityEngine.Random.Range(transform.position.x - _halfWidth, transform.position.x + _halfWidth), transform.position.y, transform.position.z), Quaternion.identity);
        }
    }   
} 
