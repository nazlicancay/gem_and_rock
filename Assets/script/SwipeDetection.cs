using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetection : MonoBehaviour
{
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (leanTouchManager.LeanTouchManagerInstance.swipeleft)
        {
           MoveLeft();
           leanTouchManager.LeanTouchManagerInstance.swipeleft = false;

        }
        
        if (leanTouchManager.LeanTouchManagerInstance.swiperight )
        {
           MoveRigt();
           leanTouchManager.LeanTouchManagerInstance.swiperight = false;

            

        }

       
      
    }
    
    public void MoveRigt()
    {
        if ( transform.position.z > 58)
        {
            Rigidbody objectRb = GetComponent<Rigidbody>();
            objectRb.AddForce(-60,0,-8,ForceMode.Impulse);
            //transform.position += Vector3.right*5 * Time.deltaTime;
            Debug.Log("sağa düşürme");
            

        }
            
    }

    public void MoveLeft()
    {
        if (transform.position.z > 58)
        {
            Rigidbody objectRb = GetComponent<Rigidbody>();
            objectRb.AddForce(30,0,4,ForceMode.Impulse);
           //transform.position += Vector3.left*5 * Time.deltaTime;
           Debug.Log("sola düşürme");



        }
    }

   
}
