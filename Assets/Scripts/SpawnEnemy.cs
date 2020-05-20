using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject [] enemypattern;

    private float timeforSpawn;
    public float startTime;
    public float decrease;
    public float minimum = 0.65f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeforSpawn <= 0)
        {
            int random = Random.Range(0, enemypattern.Length);
            Instantiate(enemypattern[random], transform.position, Quaternion.identity);
            timeforSpawn = startTime;

            if(startTime > minimum)
            {
                startTime -= decrease;
            }
            
        }

        else
        {
            timeforSpawn -= Time.deltaTime;
        }
        
    }
}
