using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SlidingPuzzle : MonoBehaviour
{
    public int puzzleSize = 4; // Adjust this to change the size of the puzzle (e.g., 3x3)
    public GameObject[,] tiles_prefab = new GameObject[4,4];

    [Serializable]
    public class Tiles
    {
        public GameObject[] tile = new GameObject[4];
    }
    public Tiles[] tiles = new Tiles[4];



}
