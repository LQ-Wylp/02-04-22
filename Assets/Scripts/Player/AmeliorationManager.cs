using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmeliorationManager : MonoBehaviour
{
    public static AmeliorationManager _AmeliorationManager;

    void Awake()
    {
        if(AmeliorationManager._AmeliorationManager == null)
        {
            _AmeliorationManager = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        // ARME 1
        _Bullet1.Dammage = Arm1_Dommage;
        _Arme1.FrequenceTir = Arm1_Frequence;

        // ARME 2
        _Bullet2.Dammage = Arm2_Dommage;
        _Arme2.FrequenceTir = Arm2_Frequence;

        // ARME 3
        _Bullet3.Dammage = Arm3_Dommage;
        _Arme3.FrequenceTir = Arm3_Frequence;
        _Bullet3.TauxScale = Arm3_Scale;
    }

    [Header("Arme : 1")]
    public Arme_1 _Arme1;
    public Bullet_1 _Bullet1;
    public float Arm1_Dommage = 5; // Init = 5 + 3
    public int Arm1_Dommage_Nb_Upgrade = 0;
    public float Arm1_Frequence = 1.5f; // Init = 1.5s - 0.2s (Bloque à 0.3s)
    public int Arm1_Frequence_Nb_Upgrade = 0; // Max 6

    public void Upgrade_Arm1_Dommage(){Arm1_Dommage_Nb_Upgrade ++; Arm1_Dommage = 5 + 3 * Arm1_Dommage_Nb_Upgrade; _Bullet1.Dammage = Arm1_Dommage;}
    public void Upgrade_Arm1_Frequence(){Arm1_Frequence_Nb_Upgrade ++; Arm1_Frequence = 1.5f - 0.2f * Arm1_Frequence_Nb_Upgrade; _Arme1.FrequenceTir = Arm1_Frequence;}


    [Header("Arme : 2")]
    public Arme_2 _Arme2;
    public Bullet_2 _Bullet2;
    public float Arm2_Dommage = 15; // Init = 15 + 4
    public int Arm2_Dommage_Nb_Upgrade = 0;
    public float Arm2_Frequence = 6; // Init = 6 - 0.5s (Bloque à 3s)
    public int Arm2_Frequence_Nb_Upgrade = 0; // Max 6

    public void Upgrade_Arm2_Dommage(){Arm2_Dommage_Nb_Upgrade ++; Arm2_Dommage = 15 + 4 * Arm2_Dommage_Nb_Upgrade; _Bullet2.Dammage = Arm2_Dommage;}
    public void Upgrade_Arm2_Frequence(){Arm2_Frequence_Nb_Upgrade ++; Arm2_Frequence = 6 - 0.5f * Arm2_Frequence_Nb_Upgrade; _Arme2.FrequenceTir = Arm2_Frequence;}


    [Header("Arme : 3")]
    public Arme_3 _Arme3;
    public Bullet_3 _Bullet3;
    public float Arm3_Dommage = 7; // Init = 7 + 2
    public int Arm3_Dommage_Nb_Upgrade = 0;
    public float Arm3_Frequence = 5; // Init = 5 - 0.4s (Bloque à 3s)
    public int Arm3_Frequence_Nb_Upgrade = 0; // Max 5
    public float Arm3_Scale = 5; // Init = 5 + 5 (Bloque à 25)
    public int Arm3_Scale_Nb_Upgrade = 0; // Max 4

    public void Upgrade_Arm3_Dommage(){Arm3_Dommage_Nb_Upgrade ++; Arm3_Dommage = 7 + 2 * Arm3_Dommage_Nb_Upgrade; _Bullet3.Dammage = Arm3_Dommage;}
    public void Upgrade_Arm3_Frequence(){Arm3_Frequence_Nb_Upgrade ++; Arm3_Frequence = 5 - 0.4f * Arm3_Frequence_Nb_Upgrade; _Arme3.FrequenceTir = Arm3_Frequence;}
    public void Upgrade_Arm3_Scale(){Arm3_Scale_Nb_Upgrade ++; Arm3_Scale = 5 + 5 * Arm3_Scale_Nb_Upgrade; _Bullet3.TauxScale = Arm3_Scale;}
}
