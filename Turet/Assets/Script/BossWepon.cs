using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWepon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Weponp;
    public GameObject weponplazer;
    public GameObject Effect;
    public GameObject Wepon2;
    public GameObject weponplazer2;
    public GameObject Effect2;
    public GameObject Wepon3;
    public GameObject weponplazer3;
    public GameObject Effect3;
    public GameObject Wepon4;
    public GameObject weponplazer4;
    public GameObject Effect4;
    public GameObject Wepon5;
    public GameObject weponplazer5;
    public GameObject Effect5;
    public GameObject Wepon6;
    public GameObject weponplazer6;
    public GameObject Effect6;
    public AudioSource Lazer;
    float randomX, randomY;
    float timer=0.0f;
    bool setative = false;
    float setativeTimer =0.0f;
    float setativeWaittime= 2.0f;
    float waittime = 5.0f;

    float alltime = 0.0f;
    float waitalltime = 20.0f;

    float TrueTimer = 0.0f;
    float WaitTrueTime = 2.0f;
    bool StartBool = false;
    
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

        // alltime+= Time.deltaTime;
        // if (alltime >= waitalltime)
        // {
        TrueTimer += Time.deltaTime;
      if(TrueTimer>=WaitTrueTime)
        {
            StartBool = true;
            TrueTimer = 0;
        }
        if (StartBool == true)
        {


            if (setative == false)
            {
                timer += Time.deltaTime;
                if (timer > waittime)
                {
                    randomX = Random.Range(1, 3);
                    randomY = Random.Range(4, 6);
                    timer = 0;
                    setative = true;

                }
            }
            if (setative == true)
            {
                
                setativeTimer += Time.deltaTime;
                if (setativeTimer > setativeWaittime)
                {
                    weponplazer.SetActive(false);
                    weponplazer2.SetActive(false);
                    weponplazer3.SetActive(false);
                    weponplazer4.SetActive(false);
                    weponplazer5.SetActive(false);
                    weponplazer6.SetActive(false);
                    timer = 0;
                    setative = false;
                }
                Lazer.Play();
            }
            if (randomX == 1)
            {
                weponplazer.SetActive(true);
              //  Lazer.Play();
            }
            if (randomX == 2)
            {
                weponplazer2.SetActive(true);
               // Lazer.Play();
            }
            if (randomX == 3)
            {
                weponplazer3.SetActive(true);
                //Lazer.Play();
            }
            if (randomY == 4)
            {
                weponplazer4.SetActive(true);

            }
            if (randomY == 5)
            {
                weponplazer5.SetActive(true);
            }
            if (randomY == 6)
            {
                weponplazer6.SetActive(true);
            }
            
           // alltime = 0;
        }
       // }
    }
}
