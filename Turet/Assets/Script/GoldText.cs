using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoldText : MonoBehaviour
{
    // Start is called before the first frame update
    public MAKER mak;
    public Text gold;
    float UpGold = 20;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        gold.text = "Gold : " + mak.fGold;   
        
    }
}
