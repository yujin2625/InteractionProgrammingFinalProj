using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorController : MonoBehaviour
{
    public Sprite[] sprites;
    SpriteRenderer SpriteRenderer;
    private void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void SetCharactorImage(int i)
    {
        SpriteRenderer.sprite = sprites[i];
    }

}
