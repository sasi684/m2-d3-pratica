using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio8 : MonoBehaviour
{
    public int voto;

    // Start is called before the first frame update
    void Start()
    {
        if (voto == 10)
            Debug.Log("A+");
        else if (voto == 9)
            Debug.Log("A");
        else if (voto == 8 || voto == 7)
            Debug.Log("B");
        else if (voto == 6)
            Debug.Log("C");
        else if (voto == 5)
            Debug.Log("D");
        else if (voto <= 4 && voto >= 0)
            Debug.Log("F");
        else
            Debug.Log("Il voto inserito non e' valido");
    }
}
