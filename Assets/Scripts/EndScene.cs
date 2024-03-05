using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndScene : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadSceneAsync(0);
    }
    
    public void Retry()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
