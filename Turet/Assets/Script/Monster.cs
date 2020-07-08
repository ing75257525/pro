using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class Monster : MonoBehaviour
{
    // Start is called before the first frame update
    NavMeshAgent agent;
    public Transform play;
    public GameObject im;
    public Animator ma;
    public MAKER mak;
    float randomitem;
    public GameObject Item;
 // public  bool sh;
    bool dead = true;
    public GameObject HitEffect;
    public GameObject HitEffect2;
    public GameObject DeadEffect;
   

    public float hp = 50;
    float timer = 0.0f;
    float Waittime = 5.0f;
    float DeadTimer = 0.0f;
    float WaitDeadTime = 0.25f;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        HitEffect.SetActive(false);
        //S GameObject obj = GameObject.Find(typeof(MyObject));

        agent.speed = 3.5f;
        play = GameObject.Find("Playerim").GetComponent<Transform>();
      //  Item = GameObject.Find("Item").GetComponent<GameObject>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Knife"))
        {
            hp -= mak.fAttack;
            ma.SetBool("Hit", true);
            HitEffect.SetActive(true);
            agent.speed = 1.5f;
           
        }
        if(collision.CompareTag("Player"))
        {
            // Destroy(this.gameObject);
            hp -= 10;
        }
      
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Knife"))
        {
            agent.speed = 3.5f;
            HitEffect.SetActive(false);
            ma.SetBool("Hit", false);

        }
       

    }
   
    void Update()
    {
       
       
        if (hp<=0)
        {
            mak.fDeadCount += 1;
            mak.fGold += 20;
            dead = false;
            randomitem = Random.Range(0, 5);
            //if(randomitem==2)
            //{
            //    Item.SetActive(true);
            //}
            DeadEffect.SetActive(true);
          //  this.gameObject.SetActive(false);
           // this.gameObject.SetActive(false);
        

            //  this.gameObject.SetActive(false);
            DeadTimer += Time.deltaTime;
          if(DeadTimer>=WaitDeadTime)
            {
                Destroy(this.gameObject);

                DeadTimer = 0;
            }
        }
       //    transform.eulerAngles = new Vector3(90, 0.0f, 0);
       if(dead==true)
        {
                agent.destination = play.position;
        }
     
    }
    
    void FixedUpdate()
    {
       

    }

}
