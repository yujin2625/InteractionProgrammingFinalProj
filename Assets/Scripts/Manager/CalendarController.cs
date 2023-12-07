using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalendarController : MonoBehaviour
{
    public GameObject nextCanvas;
    void Start()
    {
        StartCoroutine(Timer());
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(3f);
        nextCanvas.SetActive(true);
        gameObject.SetActive(false);
    }

}
