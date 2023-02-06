using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MainScene 1");
    }

    public void Rule()
    {
        SceneManager.LoadScene("RuleScene");
    }

    public void BackToStart()
    {
        SceneManager.LoadScene("StartScene");
    }
}
