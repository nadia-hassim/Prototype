using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public Rigidbody2D player;

    private Vector2 target;
    //public float yDistance;
    public float speed;
    //public float max;
    //public float min;
    public TextMeshProUGUI healthText;
    public int health;

    public GameObject Restart;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        
        
         float yMovement = Input.GetAxis("Vertical") * speed;


         Vector3 velo = player.velocity;
         velo.y = yMovement;
         player.velocity = velo;
        
        
    }

    // Update is called once per frame
    private void Update()
    {
        healthText.text = health.ToString();

        if(health <= 0)
        {
            Restart.SetActive(true);
            Destroy(gameObject);
        }

        //transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        //if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < max)
        //{
          //  target = new Vector2(transform.position.x, transform.position.y + yDistance);
            //transform.position = target;
            
        //}

        //else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > min)
       // {
          //  target = new Vector2(transform.position.x, transform.position.y - yDistance);
            //transform.position = target;
       // }
    }
}
