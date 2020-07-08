using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Kniffe : MonoBehaviour
{
    // Start is called before the first frame 
    public float Speed;
    public GameObject Player;
    float timer=0.0f;
    float waittime = 10.0f;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
       // Player.gameObject.transform.position = this.transform.position;
       if(Speed>=800)
        {
            timer += Time.deltaTime;
            if(timer>waittime)
            {
                Speed = 500;
                timer = 0;
            }

        }
    }
    void FixedUpdate()
    {
        transform.RotateAround(Player.transform.position, Vector3.down, Speed * Time.deltaTime);
    }
}
