using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpSystemPlayer : MonoBehaviour
{
    private float HealthRemaning;
    public float MaxHealth;

    public Slider _JaugeHP;

    // Start is called before the first frame update
    void Start()
    {
        HealthRemaning = MaxHealth;
        _JaugeHP.value = HealthRemaning / MaxHealth;
    }

    public void TakeDammage(float dommage)
    {
        HealthRemaning -= dommage;
        
        if(HealthRemaning <= 0)
        {
            Debug.Log("T'es mort");
        }

        _JaugeHP.value = HealthRemaning / MaxHealth;
    }

    public void Heal(float value)
    {
        HealthRemaning += value;
        if(HealthRemaning > MaxHealth)
        {
            HealthRemaning = MaxHealth;
        }
    }
}
