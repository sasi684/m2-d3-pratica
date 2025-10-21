using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    public int num1, num2, num3, num4;

    // Start is called before the first frame update
    void Start()
    {
        int sum = num1 + num2 + num3 + num4;
        int product = num1 * num2 * num3 * num4;
        int avg = sum / 4;
        Debug.Log(sum);
        Debug.Log(product);
        Debug.Log(avg);
    }
}