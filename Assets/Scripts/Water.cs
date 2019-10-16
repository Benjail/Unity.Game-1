using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public float DrawnCoolDown;
    private float _time;
    public int Damage;
    private Player _player;                                         
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _player = collision.gameObject.GetComponent<Player>();            
        }
    }
    private void OnTriggerStay2D(Collider2D collision)                  
    {
        if(collision.gameObject.CompareTag("Player"))               
        {
            _time -= Time.deltaTime;                                     
            if (_time < 0)  
            { 
                _player.TakeDamage(Damage);                             
                _time = DrawnCoolDown;                                  
            }
        }
    }
}
