using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GroundChecker))]
public class MoveObject : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpforce;

    private Rigidbody2D _rigidbody2D;
    private GroundChecker _groundChecker;
    public void Move()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        _rigidbody2D.velocity = new Vector2(Horizontal * _speed, _rigidbody2D.velocity.y);
        if (Horizontal > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);            
        }
        else if (Horizontal < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetKeyDown(KeyCode.Space) && _groundChecker.CheckGround())
        {
            Jump();
        }
    }
    private void Jump()
    {
        _rigidbody2D.AddForce(Vector2.up * _jumpforce, ForceMode2D.Impulse);
    }
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();                                                  
        _groundChecker = GetComponent<GroundChecker>();
    }
}
