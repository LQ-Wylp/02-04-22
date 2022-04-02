using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmplacementAmelioration : MonoBehaviour
{
    public List<GameObject> _MesAmeliorations;

    public void ActivatedRandom()
    {
        int rand = Random.Range(0, _MesAmeliorations.Count);
        _MesAmeliorations[rand].SetActive(true);
    }

    public void CloseThis()
    {
        for(int i = 0; i < _MesAmeliorations.Count; i++)
        {
            _MesAmeliorations[i].SetActive(false);
        }
    }
}
