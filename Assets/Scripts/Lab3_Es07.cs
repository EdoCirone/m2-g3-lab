using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_Es07 : MonoBehaviour
{
    public int a = 0;
    public int b = 2;
    // Start is called before the first frame update
    void Start()
    {
        if (a < b)
        {
            Debug.Log("il numero più alto è " + b);
        }
        else
            Debug.Log("il numero più alto è " + a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
