using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class InGameUI : MonoBehaviour
{
    [SerializeField] private AirDrop _airDrop;
    [SerializeField] private Spawner _spawner;
    [SerializeField] private Text _countDimonds;

    private void Start()
    {
        _spawner.GoldCollected += ShowCoins; 
    }
    private void ShowCoins(int gold)
    {
        _countDimonds.text = (_airDrop.CountGold-gold).ToString();
    }
}   
