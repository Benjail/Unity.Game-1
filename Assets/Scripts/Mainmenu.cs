using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public Animator Aboutanimator;
    public void Play()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Upravlenie()
    {
        SceneManager.LoadScene("Управление");
    }
    public void About()
    {
        Aboutanimator.SetBool("IsOpen", !Aboutanimator.GetBool("IsOpen"));
    }
    public void Exit()
    {
        Application.Quit();
    }
}
