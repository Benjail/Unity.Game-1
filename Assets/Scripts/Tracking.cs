using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracking : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _trackingObject;                    
    [SerializeField] private float _marginY;

    public Vector3 GetMarginedPosition(float marginY)
    {
        return new Vector3(_trackingObject.transform.position.x, _trackingObject.transform.position.y + marginY, transform.position.z);
    }
    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, GetMarginedPosition(_marginY), _speed * Time.deltaTime);
    }
}
