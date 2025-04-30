using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_Es03 : MonoBehaviour

{
    public int a = 5;
    public int b = 8;
    public int c = 7;
    public int d = 8;
    private int somma = 0;
    private int prodotto = 0;
    private int media = 0;

    // Start is called before the first frame update
    void Start()
    {

        somma = a + b + c + d;
        prodotto = a * b * c * d;
        media = (somma)/ 2;

        Debug.Log("la somma è uguale a " + somma);
        Debug.Log("il prodotto è uguale a " + prodotto);
        Debug.Log("la media è uguale a " + media);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
