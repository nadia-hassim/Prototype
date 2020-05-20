using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooky : MonoBehaviour
{
    public Animator camanimator;

    public void CamShake()
    {
        camanimator.SetTrigger("Shake");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
