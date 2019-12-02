using System.Collections;   
using System.Collections.Generic;  
using UnityEngine;

public class AirDrop : MonoBehaviour 
{
    [SerializeField] private GameObject _barrierPrefab;                     
    [SerializeField] private float _halfWidth;                              
    [SerializeField] private GameObject _gold;                                  

    private int _countGold;        
    public int CountGold { get=>_countGold; private set=>_countGold=value;}

    private int GetRandomGoldCount()                                               
    {
        return Random.Range(0, 10);                                         
    }
    public void InstantiateObject(GameObject gameObject)                                
    {
        Instantiate(gameObject,transform.position + new Vector3(Random.Range(- _halfWidth, + _halfWidth),0, 0), Quaternion.identity);
    }                                    
    private void Start()                                                        
    {
        _countGold = GetRandomGoldCount();                                       
        for (int i = 0; i < _countGold; i++)                                   
        { 
            InstantiateObject(_gold);                                       
            InstantiateObject(_barrierPrefab);
        }
    }   
} 
