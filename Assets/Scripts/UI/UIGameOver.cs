using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGameOver : MonoBehaviour
{
    public TextMeshProUGUI textTemps;
    public TextMeshProUGUI textNbEnnemiTue;
    public TextMeshProUGUI textLevel;

    void Start()
    {
        textTemps.text = "Temps : " + GameOverScore.Chronos.ToString("0.00") + "s";
        textNbEnnemiTue.text = "Vous avez tué : " + GameOverScore.EnnemiTue + " ennemis";
        textLevel.text = "Vous avez atteins le level : " + GameOverScore.Level;
    }
}
