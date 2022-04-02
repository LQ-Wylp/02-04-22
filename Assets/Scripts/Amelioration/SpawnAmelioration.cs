using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAmelioration : MonoBehaviour
{
    public List<EmplacementAmelioration> _MesEmplacementsAmeliorations;

    public void LevelUp()
    {
        gameObject.SetActive(true);
        for(int i = 0; i < _MesEmplacementsAmeliorations.Count; i++)
        {
            _MesEmplacementsAmeliorations[i].ActivatedRandom();
        }
        Time.timeScale = 0;
    }

    public void CloseAll()
    {
        for(int i = 0; i < _MesEmplacementsAmeliorations.Count; i++)
        {
            _MesEmplacementsAmeliorations[i].CloseThis();
        }
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
