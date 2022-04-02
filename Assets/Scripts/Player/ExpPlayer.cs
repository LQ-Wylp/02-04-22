using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpPlayer : MonoBehaviour
{
    public int _Level;
    private float _ExpLevelCurrent;
    public float _NbExpForLevelUp;
    public float _CoefExpByLevel;

    public void TakeExp(int exp)
    {
        _ExpLevelCurrent += exp;
        if(_ExpLevelCurrent >= _NbExpForLevelUp)
        {
            _ExpLevelCurrent -= _NbExpForLevelUp;
            LevelUp();

            _NbExpForLevelUp *= _CoefExpByLevel;
        }
    }

    public void LevelUp()
    {
        _Level ++;

    }
}
