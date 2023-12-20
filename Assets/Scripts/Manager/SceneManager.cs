using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public partial class GameManager
{

    public int SceneNum;
    public string[] Scenes;
    
    private void Start()
    {
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(Scenes[SceneNum++]);
    }

}
