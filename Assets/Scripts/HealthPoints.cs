using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPoints : MonoBehaviour
{
    [SerializeField] float baseLives = 4;
    [SerializeField] int damage = 1;
    float health;
    Text healthText;

    void Start()
    {
        health = baseLives - PlayerPrefsController.GetDifficulty();
        healthText = GetComponent<Text>();
        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        healthText.text = health.ToString();
    }


    

    public void TakeLife()
    {
        health -= damage;
        UpdateDisplay();
        if (health <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }

    }


}
