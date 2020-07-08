using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shop2 : MonoBehaviour
{
    public MAKER mak;
    public static float upgold = 20;
    public Text Upgoldetext;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Upgoldetext.text = "속도 :$ " + upgold;
    }
    public void OnClick()
    {
        if(mak.fGold>=upgold)
        {
               mak.fSpeed += 2 ;
            mak.fGold -= upgold;
            upgold += 10;
        }
    }
}
