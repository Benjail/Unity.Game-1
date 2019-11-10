using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{
    [SerializeField] private AirDrop _airDrop;
    [SerializeField] private Player _player;
    [SerializeField] private Text _countDimonds;
    private int dimondsdif;
    void Update() 
    {
        dimondsdif = _airDrop.ItemsCount - _player.CountDimonds; 
        _countDimonds.text = dimondsdif.ToString();
        if (_airDrop.ItemsCount == _player.CountDimonds)
        {
            SceneManager.LoadScene("Menu");
        }
         if (Input.GetKeyDown(KeyCode.Escape))                       
        {
            SceneManager.LoadScene("Menu");                             
        }
    }
}
