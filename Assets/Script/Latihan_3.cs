using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int c = Jumlah(200 , 40);
        Debug.Log("Hasil Jumlah a dan b adalah " + c);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// Merupakan funsi penjumlahan dari 2 input angka
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    int Jumlah(int a, int b)
    {
        return a + b;
    }
}
