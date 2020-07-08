using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFireBullet : MonoBehaviour
{
    public GameObject bullet;
    public GameObject Player;
    public Transform shotpount;
    private float timebullet=0.0f;
    private float WaittimeBullet = 5.0f;
    float StartTime = 0.0f;
    float WaitStartTime = 2.0f;
    bool StartBool = false;

    private void Update()
    {
        StartTime += Time.deltaTime;
        if(StartTime>=WaitStartTime)
        {
            StartBool = true;
            StartTime = 0.0f;
        }
        if(StartBool==true)
        {

            Vector3 difference = Player.transform.position - transform.position;
            float rotz = Mathf.Atan2(difference.x, difference.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(90f, rotz+90, 0f) ;
            timebullet+=Time.deltaTime;
            if (timebullet>=WaittimeBullet)
           {

             Instantiate(bullet, shotpount.position, transform.rotation);

                timebullet = 0;
           }
         }
       
    }




}
