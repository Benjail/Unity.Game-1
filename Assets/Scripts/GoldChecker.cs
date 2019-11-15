using System.Collections;
using System.Collections.Generic;
using UnityEngine;  
using UnityEngine.SceneManagement;  

public class GoldChecker : MonoBehaviour                      
{
    [SerializeField] private AirDrop _airDrop;            
    [SerializeField] private Spawner _spawner;                

   public bool IsGoldCollected()
    {
        return _airDrop.GetItemsCount() == _spawner.GetCountDimonds();
    }
   private void Update()        
    {       
        if (IsGoldCollected())     
        {
            SceneManager.LoadScene("Menu");         
        }       
    }       
}       
