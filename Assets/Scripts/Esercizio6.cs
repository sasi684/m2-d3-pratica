using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio6 : MonoBehaviour
{
    public int num1, num2;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 > num2)
            Debug.Log(num1);
        else
            Debug.Log(num2);
    }
}
