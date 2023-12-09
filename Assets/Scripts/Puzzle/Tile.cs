using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Tile : MonoBehaviour
{
    public int curIndex;
    public static int Index;

    public int GetCurIndex()
    {
        return curIndex;
    }
    public int GetIndex()
    {
        return  Convert.ToInt32(gameObject.name.Substring(gameObject.name.IndexOf('_')));
    }
}