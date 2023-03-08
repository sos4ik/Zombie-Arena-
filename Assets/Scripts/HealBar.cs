using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    public void SetMaxHealth(int health)
    {
        _slider.maxValue = health;
        _slider.value = health;
    }
    public void SetHeal(int health)
    {
        _slider.value = health;
    }


}
