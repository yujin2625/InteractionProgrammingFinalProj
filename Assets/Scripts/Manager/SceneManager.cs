using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public partial class GameManager
{
    SceneManager SceneManager;

    public string currentScene;
    public string[] Scenes;
    Queue<string> scene_queue;
    private void Start()
    {
        foreach (string scene in Scenes ){
            scene_queue.Enqueue(scene);
        }
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(scene_queue.Dequeue());
        Scenes = Array.Empty<string>();
        Scenes = scene_queue.ToArray();
    }

}
