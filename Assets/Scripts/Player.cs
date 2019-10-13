using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent (typeof(GroundChecker))]
public class  Player : MonoBehaviour
{
    
    public int Health;
    public int CountDimonds;
    public GameObject Inventory;
    public GameObject AirDrop;
    public float Speed;
    public float Jumpforce;
    private Rigidbody2D _rigidbody2D; //создаю физ тело 
    private Animator _animator;  //аниматор 
    private GroundChecker _groundchecker;
    public AirDrop _airdrop;
    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
    private void Jump()
    {
        _rigidbody2D.AddForce(Vector2.up * Jumpforce, ForceMode2D.Impulse);
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Chest"))
        {
            Debug.Log("Коснулись сундука");
        }
    }*/
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chest")&&Input.GetKeyDown(KeyCode.E))
        {
            collision.gameObject.GetComponent<Chest>().Open();
        }
        if (collision.gameObject.CompareTag("Item"))
        {         
            collision.gameObject.SetActive(false);
            collision.gameObject.transform.SetParent(Inventory.transform);
            CountDimonds += 1;
        }
    }
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();                             
        _animator = GetComponent<Animator>();                       
        _groundchecker = GetComponent<GroundChecker>();
        _airdrop= GetComponent<AirDrop>(); 
    }                                                                                                                                                      
    void Update()                                                           
    {                                                                       
        float horizontal = Input.GetAxisRaw("Horizontal");                  
        _rigidbody2D.velocity = new Vector2(horizontal* Speed, _rigidbody2D.velocity.y); 
        if (horizontal > 0)
        {
            _animator.SetBool("IsWalk", true);
            transform.localScale = new Vector3(1, 1, 1);                    
        }
        else if (horizontal < 0)                                        
        {                                                                       
            _animator.SetBool("IsWalk", true);                              
            transform.localScale = new Vector3(-1, 1, 1);               
        }
        else if (horizontal == 0)
        {
            _animator.SetBool("IsWalk", false);         
        }
        if (Input.GetKeyDown(KeyCode.Space) && _groundchecker.CheckGround())// почему не прыгает
        {
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.Escape))//выход в главное меню
        {
            SceneManager.LoadScene("Меню");
        }
        if (_airdrop.ItemDatas.Count == CountDimonds) 
        {
            SceneManager.LoadScene("Меню");                     
        }
    }
}   



