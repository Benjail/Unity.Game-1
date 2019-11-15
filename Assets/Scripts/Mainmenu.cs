using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Mainmenu : MonoBehaviour 
{
    [SerializeField] private Animator Aboutanimator;    
    private void Play() 
    {
        SceneManager.LoadScene("Level 1");  
    }
    private void About()
    {
        Aboutanimator.SetBool("IsOpen", !Aboutanimator.GetBool("IsOpen")); 
    }
    private void Exit()     
    {
        Application.Quit(); 
    }
}
