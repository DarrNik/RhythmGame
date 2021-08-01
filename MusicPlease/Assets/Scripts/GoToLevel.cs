using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void GoTo(string name)
    {
            SceneManager.LoadScene(name);
    }

    //public void Exit() 
    //{
    //    Application.Quit();
    //}
}
