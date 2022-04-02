using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arme_1 : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject Target;
    public List<GameObject> EnnemiAtRange;

    public float FrequenceTir;
    private float Timer;

    void Update()
    {
        Timer += Time.deltaTime;
        if(Timer > FrequenceTir)
        {
            Timer = 0;
            Shot();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ennemi")
        {
            EnnemiAtRange.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Ennemi")
        {
            EnnemiAtRange.Remove(other.gameObject);
            if(Target == other)
            {
                Target = null;
            }
        }
    }

    public void UpdateTarget()
    {
        if(EnnemiAtRange != null)
        {
            GameObject newTarget = null;
            float distanceNewTarget = Mathf.Infinity;
            for(int i = 0; i < EnnemiAtRange.Count; i++)
            {
                if(EnnemiAtRange[i] != null)
                {
                    if(Vector3.Distance(PlayerManager._playerManager.Player.transform.position, EnnemiAtRange[i].transform.position) < distanceNewTarget)
                    {
                        newTarget = EnnemiAtRange[i];
                        distanceNewTarget = Vector3.Distance(PlayerManager._playerManager.Player.transform.position, EnnemiAtRange[i].transform.position);
                    }
                }
            }
            Target = newTarget;
        }

        for(int i = 0; i < EnnemiAtRange.Count; i++)
        {
            if(EnnemiAtRange[i] == null)
            {
                EnnemiAtRange.Remove(EnnemiAtRange[i]);
                i--;
            }
        }
    }
    public void Shot()
    {
        UpdateTarget();
        if(Target != null)
        {
            GameObject LastBullet = Instantiate(Bullet, transform.position, Quaternion.identity);
            LastBullet.GetComponent<Bullet_1>().AtSpawn(Target);
        }
    }

}
