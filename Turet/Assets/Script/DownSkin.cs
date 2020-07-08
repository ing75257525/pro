using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownSkin : MonoBehaviour
{
    // Start is called before the first frame update
    public MAKER mak;
    public SpriteRenderer sp;
    void Start()
    {
        mak.fDeadCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        if(mak.skinnum - 2 < 0)
        {
            mak.skinnum = mak.sp.Length - 1;
            sp.sprite = mak.sp[mak.skinnum];

            return;
        }
        mak.skinnum -= 2;
        sp.sprite = mak.sp[mak.skinnum];


    }
}
