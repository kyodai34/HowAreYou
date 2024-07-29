using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerController : MonoBehaviour
{
    public Sprite rageSprite;
    public Sprite normal;
    public GameObject mob;
    private SpriteRenderer _spriteChanger;
    public GameObject food;
    private void Start()
    {
        _spriteChanger = mob.GetComponent<SpriteRenderer>();
        _spriteChanger.sprite = normal;
        food.SetActive(false);
    }

    public void SpriteChange()
    {
        _spriteChanger.sprite = rageSprite;
    }

    public void FoodOrder()
    {
        food.SetActive(true);
    }
}
