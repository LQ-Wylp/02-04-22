using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpSystemMonster : MonoBehaviour
{
    private float HealthRemaning;
    public float MaxHealth;

    public float BonusHpByUpgradeDifficulte;

    public GameObject Exp;
    public GameObject Aimant;
    public GameObject Heal;

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

            int rand = Random.Range(0,100);
            if(rand == 15)
            {
                Instantiate(Aimant, transform.position, Quaternion.identity);
            }
            if(rand < 5)
            {
                Instantiate(Heal, transform.position, Quaternion.identity);
            }
            ArgentDuCompte.Argents ++;
            Destroy(gameObject);
        }
    }

    public void BonusDifficulter(int NbAugmentation)
    {
        HealthRemaning += NbAugmentation * BonusHpByUpgradeDifficulte;
        MaxHealth += NbAugmentation * BonusHpByUpgradeDifficulte;
    }
}
