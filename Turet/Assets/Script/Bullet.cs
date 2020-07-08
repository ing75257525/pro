using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 20.0f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.left * Speed * Time.deltaTime);

    }
    void OnTriggerEnter(Collider collision)
    {
        
            if (collision.CompareTag("Player"))
            {
               Destroy(this.gameObject);
            }
        

    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
