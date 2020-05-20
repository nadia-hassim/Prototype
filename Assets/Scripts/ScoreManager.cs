using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int points;
    public TextMeshProUGUI pointsText;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = points.ToString();
        player = GameObject.FindWithTag("Player");

        if(player == null)
        {
            pointsText.text = "You died";
            
        }


    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //if(collision.CompareTag("Obstacle"))
        //{
          //  points++;
            //Debug.Log(points);
        //}

        if (collision.CompareTag("Obstacle"))
        {
            points++;
            Debug.Log(points);
        }
    }

}
