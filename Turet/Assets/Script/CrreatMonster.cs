using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrreatMonster : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject Enemy; 
    public MAKER mak;
    void SpawnEnemy()
    {
        float randomX = Random.Range(-11.0f, 11.0f); 
        if (enableSpawn)
        {
            GameObject enemy = (GameObject)Instantiate(Enemy, new Vector3(randomX, 2.524328f, 0f), Quaternion.identity);
           // enemy.GetComponent<Monster>().play.position ;
        }
    }
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 3, 1);
        enableSpawn = true;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Logo");
        }
        if (mak.fDeadCount >= 750)
        {
            SceneManager.LoadScene("Boss");
        }
    }
}
