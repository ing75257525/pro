        using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    public float Speed = 20f;
    void start()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("Wall"))
        {
            Destroy(this.gameObject);

        }
        if (collision.CompareTag("Boss"))
        {

            Destroy(this.gameObject);
        }
        if (collision.CompareTag("Monster"))
        {

            Destroy(this.gameObject);
        }
        if (collision.CompareTag("Sk"))
        {

            Destroy(this.gameObject);
        }
    }
    void FixefUpdate()
    {

    }
    void Update()
    {
        transform.Translate(Vector3.right * Speed * Time.deltaTime);

    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
