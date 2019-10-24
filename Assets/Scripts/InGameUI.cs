using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{
    public AirDrop airDrop;
    public Player Player;
    public Text CountDimonds;
    private void Update()
    {
        int dimondsdif = airDrop.ItemDatas.Count - Player.CountDimonds;
        CountDimonds.text = dimondsdif.ToString();   
    }
}
