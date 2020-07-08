using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossKniffe : MonoBehaviour
{
    // Start is called before the first frame 
    public float Speed=300;
    public GameObject Player;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        // Player.gameObject.transform.position = this.transform.position;
    }
    void FixedUpdate()
    {
        transform.RotateAround(Player.transform.position, Vector3.down, Speed * Time.deltaTime);
    }
}
