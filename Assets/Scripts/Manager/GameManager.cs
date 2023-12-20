using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public partial class GameManager : MonoBehaviour
{
    public GameObject StoryManager;
    public GameObject GameClear;

    public Slider PuzzleGage, CureGage;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void PuzzleClear()
    {
        GameClear = GameObject.Find("GameClear");
        GameClear.SetActive(true);
    }

}
