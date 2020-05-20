using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWave : MonoBehaviour
{
    public GameObject enemy;
    private Rigidbody2D enemyy;
    public float spawntime = 0.5f;
    float newspawn = 0.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
       
        
       if (Time.time > newspawn)
       {

            int xpos = Random.Range(0, 5);
            int ypos = Random.Range(-5, 5);


            newspawn = Time.time + spawntime;
           // int randomxpos = 10;
          //  int randomypos = 2;
            Vector2 athing = new Vector2(xpos, ypos);
            Instantiate(enemy, athing, Quaternion.identity);
       }
        
        
       

    }
    



}
