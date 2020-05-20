using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject collideEffect;
    public float speed;
    public int powerUp;

    private Shooky shook;

    // Start is called before the first frame update
    void Start()
    {
        shook = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shooky>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            shook.CamShake();
           Instantiate(collideEffect, transform.position, Quaternion.identity);

            collision.GetComponent<Player>().health += powerUp;
            Debug.Log(collision.GetComponent<Player>().health);
            Destroy(gameObject);
        }
    }
}
