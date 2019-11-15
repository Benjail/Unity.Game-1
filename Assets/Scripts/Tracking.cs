using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracking : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private float _marginY;
    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(_gameObject.transform.position.x, _gameObject.transform.position.y+_marginY, transform.position.z),_speed*Time.deltaTime);
    }
}
