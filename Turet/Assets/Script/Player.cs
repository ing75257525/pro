using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player: MonoBehaviour
{
    public float PlayerSpeed;
    public GameObject Item;
    Rigidbody PlayerRb2d;
    public float hp=20;
    public MAKER mak;
    private SpriteRenderer sp;
    public Slider hpslider;
    public Slider DKSlider;
    public SIBALCAM Sc;
    float ItemTime = 0.0f;
    float WaititemTime = 15.0f;
    bool IT = true;
    void Start()
    {
        hp = 20;
        PlayerRb2d = GetComponent<Rigidbody >();
      
   
   //     Sc = GetComponent<SIBALCAM>();
        sp = GetComponent<SpriteRenderer>();
        sp.sprite = mak.sp[mak.skinnum];

    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Monster"))
        {
            hp -= 1;
           Sc.ShakeCamera();
            
        }
        if (collision.CompareTag("Lazer"))
        {
            hp --;
            Sc.ShakeCamera();
        }
        if(collision.CompareTag("BossBullet"))
        {
            hp-=1;
            Sc.ShakeCamera();
        }
    }
    void Update()
    {
        if(IT==true)
        {
            ItemTime += Time.deltaTime;
            if(ItemTime>=WaititemTime)
            {

                Item.SetActive(true);
                IT = false;
            }

        }
        DKSlider.value = mak.fDeadCount;
        hpslider.value = hp;
       if(Input.GetKeyDown(KeyCode.M))
        {
            mak.fDeadCount = 750;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            mak.fGold = 10000;
        }

        if (hp<=0)
        {
            SceneManager.LoadScene("Logo");
        }
    }
    private void FixedUpdate()
    {
       
       float hor = Input.GetAxis("Horizontal");
       float ver = Input.GetAxis("Vertical");

      PlayerRb2d.velocity = new Vector3(hor, 0,ver) * mak.fSpeed;

       

    }
}
