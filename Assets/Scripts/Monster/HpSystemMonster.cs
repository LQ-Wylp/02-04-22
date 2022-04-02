using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpSystemMonster : MonoBehaviour
{
    private float HealthRemaning;
    public float MaxHealth;

    public GameObject Exp;

    // Start is called before the first frame update
    void Start()
    {
        HealthRemaning = MaxHealth;
    }

    public void TakeDammage(float dommage)
    {
        HealthRemaning -= dommage;
        if(HealthRemaning <= 0)
        {
            Instantiate(Exp, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
