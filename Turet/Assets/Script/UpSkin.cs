using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpSkin : MonoBehaviour
{
    public MAKER mak;
    public SpriteRenderer sp;
    void Start()
    {
        mak.fBossHp = 1000;
        mak.fDeadCount = 0;
      //  mak.fGold = 0;
      //  mak.fAttack = 10;
       // mak.fSpeed = 8;
        //mak.skinnum = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick()
    {
        if(mak.skinnum + 3 > mak.sp.Length)
        {
            mak.skinnum = 0;
            sp.sprite = mak.sp[mak.skinnum];

            return;
        }
        mak.skinnum += 1;
        sp.sprite = mak.sp[mak.skinnum];

    }
}
