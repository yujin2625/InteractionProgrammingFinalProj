using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject panel;
    public bool shake = true;
    private void Start()
    {
        ShakePanel();
    }
    public void ShakePanel()
    {
        if (shake)
        {
            Invoke(nameof(PanelLeft), 0.5f);
        }
        else
        {
            Invoke(nameof(PanelRight), 0.5f);
        }
    }
    public void PanelLeft()
    {
        panel.transform.position = new Vector3(-0.3f, -0.3f, 0);
        shake = false;
        ShakePanel();
    }
    public void PanelRight()
    {
        panel.transform.position = new Vector3(0.3f, -0.3f, 0);
        shake = true;
        ShakePanel();
    }
}
