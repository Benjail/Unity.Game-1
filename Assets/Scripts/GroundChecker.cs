using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
   [SerializeField] private GameObject _сheckpoint;//точка проверки касания
   [SerializeField] private float _radius; // радиус проверки
   [SerializeField] private LayerMask _whatisGround; //слой, который принимаем в качестве нужного (Ground)
    public bool CheckGround()                                               
    {
        return Physics2D.OverlapCircle(_сheckpoint.transform.position, _radius, _whatisGround);
    }
}
