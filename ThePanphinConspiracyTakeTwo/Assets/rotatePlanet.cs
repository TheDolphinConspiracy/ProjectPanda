﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatePlanet : MonoBehaviour
{
    public float xAngle, yAngle, zAngle;
    public GameObject planet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
    }
}
