using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class La : MonoBehaviour
{
    public int a = 0;
    public int b = 2;
    // Start is called before the first frame update
    void Start()
    {
        if (a < b)
        {
            Debug.Log("il numero più basso è " + a);
        }
        else
            Debug.Log("il numero più basso è " + b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
