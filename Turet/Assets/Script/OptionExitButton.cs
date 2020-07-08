using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionExitButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Panel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        Panel.SetActive(false);
    }
}
