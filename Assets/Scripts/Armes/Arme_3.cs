using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arme_3 : MonoBehaviour
{
    public GameObject Bullet;
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

    void Shot()
    {
        GameObject LastBullet = Instantiate(Bullet, transform.position, PlayerManager._playerManager.Player.transform.rotation);
        LastBullet.gameObject.SetActive(true);
    }
}
