﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan_2 : MonoBehaviour
{
    // Start is called before the first frame update

    public int nilaiA;
    public int nilaiB;
    [Range(1, 5)]
    public int nilaiC;
    void Start()
    {
        int total = (nilaiA + nilaiB )* nilaiC;
        Debug.Log("Total " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
