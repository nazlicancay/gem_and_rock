using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leanTouchManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static leanTouchManager LeanTouchManagerInstance;
    public bool swipeleft = false;
    public bool swiperight = false;

    private void Awake()
    {
        LeanTouchManagerInstance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
