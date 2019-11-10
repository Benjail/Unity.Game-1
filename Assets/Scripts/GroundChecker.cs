using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
   [SerializeField] private GameObject _сheckpoint;
   [SerializeField] private float _radius; 
   [SerializeField] private LayerMask _whatisGround; 
    public bool CheckGround()                                               
    {
        return Physics2D.OverlapCircle(_сheckpoint.transform.position, _radius, _whatisGround);
    }
}
