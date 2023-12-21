using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PuzzleTimer : MonoBehaviour
{
    public Slider TimerSlider;
    public GameObject GameOver;
    float time = 100;
    float timer = 100;
    private void Start()
    {
        timer = time;  
    }
    private void Update()
    {
        TimerSlider.value = time/timer;
        time -= Time.deltaTime;
        if(time <= 0)
        {
            GameOver.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameOver.SetActive(true);
        }
    }
}
