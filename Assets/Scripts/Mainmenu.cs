using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour 
{
    [SerializeField] private Animator _textAnimator;

    private void Play()
    {
        SceneManager.LoadScene("Level 1");
    }
    private void About()
    {
        _textAnimator.SetBool("IsOpen", !_textAnimator.GetBool("IsOpen"));           
    }
    private void Exit()     
    {
        Application.Quit(); 
    }
}
