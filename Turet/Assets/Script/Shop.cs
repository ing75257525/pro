using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shop : MonoBehaviour
{
    // Start is called before the first frame update
    public MAKER mak;
    public static float Upgold = 20;
    public Text textGold;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textGold.text = "공격력 :$" + Upgold;
    }
    public void OnClick()
    {

        if(mak.fGold>=Upgold)
        {

              mak.fAttack += 5;
            mak.fGold -= Upgold;
            Upgold += 10;
        }
    }
}
