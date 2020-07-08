using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bosssin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Boss;
    public Boss b;
    public MAKER mak;
    bool bs=false;
    float scaleup = 0;
    
    void Start()
    {
        mak.fBossHp = 5000;
        b = GetComponent<Boss>();
    }

    // Update is called once per frame
    void Update()
    {
        if(mak.fBossHp <= 0)
        {
            this.gameObject.SetActive(true);


            bs = true;
            scaleup++;
        }
        if(bs==true)
        {
           this.gameObject.transform.localScale=new Vector3(0,scaleup,0);
   
 
        }
    }
    void FixedUpdate()
    {

    }
}
