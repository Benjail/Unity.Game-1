using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(GroundChecker))]
public class Player : MonoBehaviour
{
    public int CountDimonds { get; private set; }
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpforce;
    private Rigidbody2D _rigidbody2D;             
    private GroundChecker _groundchecker;
    private void Jump()
    {
        _rigidbody2D.AddForce(Vector2.up * _jumpforce, ForceMode2D.Impulse);
    }
    private void OnCollisionStay2D(Collision2D collision)           
    { 
        if (collision.gameObject.CompareTag("Item"))                
        {
            collision.gameObject.SetActive(false);
            CountDimonds += 1;
        }
    }
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();                                                  
        _groundchecker = GetComponent<GroundChecker>();
    }
    void Update()                                                           
    {          
        float horizontal = Input.GetAxisRaw("Horizontal");                  
        _rigidbody2D.velocity = new Vector2(horizontal* _speed, _rigidbody2D.velocity.y); 
        if (horizontal > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);                    
        }
        else if (horizontal < 0)                                        
        {                                                                                                     
            transform.localScale = new Vector3(-1, 1, 1);               
        }       
        if (Input.GetKeyDown(KeyCode.Space) && _groundchecker.CheckGround())
        {
            Jump();
        }
    }
}  