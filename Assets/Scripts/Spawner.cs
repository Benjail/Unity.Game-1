﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MoveObject))]
[RequireComponent(typeof(EndGameChecker))]
public class Spawner : MonoBehaviour
{
    public event Action<int> GoldCollected; 

    private int _countGold;
    private MoveObject _movement;
    public int CountGold { get => _countGold; private set => _countGold = value; }

    private void OnCollisionStay2D(Collision2D collision)                           
    {
        if (collision.gameObject.CompareTag(Tags.Item))                        
        {
            Destroy(collision.gameObject);
            _countGold++;
            GoldCollected?.Invoke(_countGold);                                                  
        }
    }
    private void Start()
    {
        _movement = GetComponent<MoveObject>();                       
    }
    private void Update()                                                           
    {
        _movement.Move();                                           
    }
}  