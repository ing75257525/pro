﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
   // Rigidbody2D Rig2d;
   
    Rigidbody2D rig;
    Transform myTrans;
  //  public GameObject Hero;

   
    // private float startSpeed = 1;
    
    public float Speed;
    
    public Rigidbody objectRigidobody2d;

    Vector3 moveDir;
    Kniffe Kn;
    // Use this for initialization
    void Start()
    {
        myTrans = GetComponent<Transform>();
        float randomX, randomY;
        randomX = Random.Range(-1.0f, 1.0f);
        randomY = Random.Range(-1.0f, 1.0f);

        Vector3 vector3 = new Vector3(randomX, 0,randomY);
        moveDir = vector3 * Speed;
        Kn = GameObject.Find("Knife").GetComponent<Kniffe>();
        //objectRigidobody2d.AddForce(vector3 * Speed);
    }
    void Update()
    {
        

    }
    void FixedUpdate()
    {
        objectRigidobody2d.MovePosition(myTrans.position + moveDir);
        //rig.velocity.x++;
    }
    private void OnTriggerEnter(Collider other)
    {
        //Physics.over
        if (other.CompareTag("Player"))
        {
            Kn.Speed = 900;
            Destroy(this.gameObject);
        }
        if (other.CompareTag("Wall"))
        {
            
           // Debug.Log("fuck: " + collision.contacts.Length);
           // foreach (ContactPoint cp in collision.contacts)
            {
                //  Debug.Log("fuck22 : " + objectRigidobody2d.velocity);

                RaycastHit hit;
                Physics.Raycast(transform.position, moveDir, out hit, 10);
                if(hit.collider != null)
                {
                    Vector3 reflec = Vector3.Reflect(moveDir, hit.normal);
                    moveDir = reflec;

                }


                //Debug.DrawRay(cp.point, cp.normal * 100, Color.red, 10);
                //Debug.Log("fuck33 : " + reflec);
                //break;

            }
        }

    }

}
