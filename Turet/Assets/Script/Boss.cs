using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Boss : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public GameObject Broken;
    public GameObject BossKnife;
    public bool ist = true;
    public GameObject LastBoss;
    public GameObject Light;
    float timer=0.0f;
    float waittime=0.5f;
    float truetimer = 0.0f;
    float truewaittime = 3;
    public Sprite CurrentSprite;
    public Sprite NextSprite;
    private SpriteRenderer spr;
    public GameObject bossKnife;
    float stoptime = 0.0f;
    float stopwaittime = 10.0f;
  // public  float hp = 5000;
    public Slider hpslider;
    public MAKER mak;
    bool Hpup = false;
    bool Boss3 = false;
    bool nextBoss=true;
    public GameObject nextBoss2;
    float ScaleUp = 0.5f;
   public float count = 0;
    bool countbool = true;
    private Vector3 targetPosition;
    Rigidbody rig;
    BossKniffe Bk;
    float Lighttime = 0.0f;
    float waitLightTime = 0.1f;
    bool allFalse = false;
    float AniTime = 0.0f;
    float WaitAniTime = 0.5f;
    public  float Speed = 2;
    float TrueTime = 0.0f;
    float WaitTrueTime = 2.0f;
    void Start()
    {
        mak.fDeadCount = 0;
        mak.fBossHp = 1000;
        rig = GetComponent<Rigidbody>();
        spr = gameObject.GetComponent<SpriteRenderer>();
        Bk = GameObject.Find("BossKnife").GetComponent<BossKniffe>();

    }
    void OnTriggerEnter(Collider collision)
    {
        if (Hpup == false)
        {
            if (collision.CompareTag("Knife"))
            {
               
                mak.fBossHp -= mak.fAttack;
              //  Debug.Log(mak.fBossHp);
                //mak.fAttack += 상점 공격력 높여주는 아이템만큼!
            }
        }

    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Logo");
        }
        if (BossKnife.gameObject.transform.localScale.x < 1)
        {

            if(BossKnife.gameObject.transform.localScale.y < 1)
            {
                BossKnife.gameObject.transform.localScale = new Vector3(ScaleUp,ScaleUp,0);

                AniTime += Time.deltaTime;
                if(AniTime > WaitAniTime)
                {
                         ScaleUp += 0.1f;
                          AniTime = 0;
                }
                

            }
        }
        if (BossKnife.gameObject.transform.localScale.x > 1)
        {

            if (BossKnife.gameObject.transform.localScale.y > 1)
            {
                TrueTime += Time.deltaTime;
                if(TrueTime>=WaitTrueTime)
                {
                  allFalse = true;
                    TrueTime = 0;
                }
            }
        }
        if (allFalse == true)
        {


            // Debug.Log(Lighttime);
            if (Input.GetKeyDown(KeyCode.L))
            {
                mak.fBossHp -= 5020;
            }
            hpslider.value = mak.fBossHp;
            //  Debug.Log(count);
            if (nextBoss == true)

            {


                if (mak.fBossHp <= 0)
                {
                    Bk.Speed = 0;
                    Speed = 0;
                    Hpup = true;

                }

                if (Hpup == true)
                {
                    if (mak.fBossHp <= 1000)
                    {

                        mak.fBossHp += 50;

                    }

                    if (mak.fBossHp >= 1000)
                    {
                        spr.sprite = NextSprite;
                        count = 0;
                        Speed = 2;
                        Bk.Speed = 400;
                        Hpup = false;
                        Broken.SetActive(true);
                        StartCoroutine(WaitForIt3());
                        bossKnife.SetActive(true);
                    }
                    IEnumerator WaitForIt3()
                    {


                        yield return new WaitForSeconds(0.2f);
                        Broken.SetActive(false);
                        nextBoss = false;
                    }
                }

            }
            if (nextBoss == false)
            {
                if (mak.fBossHp <= 0)
                {
                    //Light.SetActive(true);
                    //Lighttime += Time.deltaTime;
                    // if (Lighttime >= waitLightTime)
                    // {
                    LastBoss.SetActive(true);
                    nextBoss2.SetActive(true);
                    // Lighttime = 0;
                    // }
                    this.gameObject.SetActive(false);


                }

            }
            if (count >= 3)
            {
                countbool = false;
                Bk.Speed = 0;
            }
            if (countbool == false)
            {
                stoptime += Time.deltaTime;
                if (stoptime > stopwaittime)
                {
                    countbool = true;
                    count = 0;
                    Bk.Speed = 300;
                    stoptime = 0;
                }
            }
            if (countbool == true)
            {
                if (ist == true)
                {
                    timer += Time.deltaTime;
                    if (timer > waittime)
                    {
                        ist = false;

                        timer = 0;
                    }
                }
                if (ist == false)
                {
                    truetimer += Time.deltaTime;
                    if (truetimer > truewaittime)
                    {
                        ist = true;

                        count += 1;
                        truetimer = 0;
                    }


                }
            }
        }
        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (allFalse == true)
        {


            if (countbool == true)
            {
                targetPosition = new Vector3(Player.transform.position.x, 90, Player.transform.position.z);
                transform.LookAt(targetPosition);
            }

            //rig.velocity = Vector3.back * Speed;
            Vector3 movevelocity = Vector3.zero;
            if (countbool == true)
            {
                if (ist == true)
                {

                    Vector3 playerpos = Player.transform.position;

                    if (playerpos.x < transform.position.x)
                    {

                        movevelocity.x -= Speed;

                    }

                    if (playerpos.x > transform.position.x)
                    {
                        movevelocity.x += Speed;

                    }

                    if (playerpos.z < transform.position.z)
                    {

                        movevelocity.z -= Speed;
                    }

                    if (playerpos.z > transform.position.z)
                    {

                        movevelocity.z += Speed;
                    }

                    transform.position += movevelocity * Speed * Time.deltaTime;
                }

            }
        }
    }
}
    
       

  
    

