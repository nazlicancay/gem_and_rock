using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    // Start is called before the first frame update

    public int speed = 18 ;
    public bool destroy = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward*speed * Time.deltaTime;

        if (transform.position.z > 80 || transform.position.x > 22 || transform.position.x <-22)
        {
            Destroy(gameObject);
        }
    }

   
}
