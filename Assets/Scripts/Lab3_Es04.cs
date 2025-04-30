using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_Es04 : MonoBehaviour
{

    public int partenza = 0;
    // Start is called before the first frame update
     
    // Start is called before the first frame update
    void Start()
    {
        if (partenza % 2 == 0)
        {
            Debug.Log("il numero è pari");
        }
        else
             Debug.Log("il numero non è pari");

        if (partenza >= 10)
            {
                Debug.Log("il numero è maggiore di 10");
            }
        else
            Debug.Log("il numero è minore di 10");
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
