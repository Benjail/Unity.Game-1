using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movement))]
[RequireComponent(typeof(GoldChecker))]
public class Spawner : MonoBehaviour
{                                    
    private int _countGold;
    private Movement _movement;
    public int CountGold { get => _countGold; private set => _countGold = value; }

    private void OnCollisionStay2D(Collision2D collision)                           
    {
        if (collision.gameObject.CompareTag("Item"))                        
        {
            Destroy(collision.gameObject);                                      
            CountGold ++;                                                   
        }
    }
    private void Start()
    {
        _movement = GetComponent<Movement>();
    }
    private void Update()                                                           
    {
        _movement.Move();
    }
}  