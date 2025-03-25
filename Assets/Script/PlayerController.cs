using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;

    public int Health;
    public int Mana;
    public int Exp;

    public Text HealthText;
    public Text ManaText;
    public Text ExpText;

    private void Awake()
    {
        Instance = this;
    }

    public void IncreaseHealth(int value)
    {
        Health += value;
        HealthText.text = $"HP: {Health}";
    }

    public void IncreaseMana(int value)
    {
        Mana += value;
        ManaText.text = $"Mana: {Mana}";
    }

    public void IncreaseExp(int value)
    {
        Exp += value;
        ExpText.text = $"Exp: {Exp}";
    }
}
