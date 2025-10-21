using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
{
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        if (num % 2 == 0)
            Debug.Log("Numero pari");
        else
            Debug.Log("Numero dispari");
    }
}
