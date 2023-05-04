using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlapScript : MonoBehaviour
{

    public GameObject birdWing;

    void Start() 
    {
          
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            birdWing.GetComponent<Animator>().Play("Flap");
        }
    }

}
