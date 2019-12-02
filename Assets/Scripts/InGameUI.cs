using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{
    [SerializeField] private AirDrop _airDrop;
    [SerializeField] private Spawner _spawner;
    [SerializeField] private Text _countDimonds;

    private void Update()   
    {
        _countDimonds.text = (_airDrop.CountGold - _spawner.CountGold).ToString();    
    }   
}   
