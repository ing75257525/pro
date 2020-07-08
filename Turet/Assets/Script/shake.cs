using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shake : MonoBehaviour
{
    // Start is called before the first frame update
    bool start;
    bool S=true;
    float Speed = 0.5f;
    float time = 0.0f;
   public Monster monster;
    float waittime = 0.3f;
    void Start()
    {
        monster = GetComponent<Monster>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    void FixedUpdate()
    {
       
           




        
    }
   public void Shake()
    {
        Vector3 movevelocity = Vector3.zero;
        Debug.Log("Dafasdfasdf");
        if (S == true)
        {
            time += Time.deltaTime;
            if (time > waittime)
            {
                S = false;
                transform.position += Vector3.left * Speed;
                Debug.Log("true");
                time = 0;
            }
        }
        else
        {
            time += Time.deltaTime;
            if (time > waittime)
            {
                S = true;
                transform.position += Vector3.right * Speed;
                Debug.Log("false");
                time = 0;
            }
        }
    }
}
