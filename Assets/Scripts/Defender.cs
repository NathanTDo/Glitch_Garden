﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int starCost = 100;


    public void AddStar(int amount)
    {
        FindObjectOfType<StarDisplay>().AddStars(amount);
        UnityEngine.Debug.Log("Hi");
    }

    public int GetStarCost() { return starCost; }
}
