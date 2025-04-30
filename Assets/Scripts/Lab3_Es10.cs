using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_Es10 : MonoBehaviour
{
    public int voto = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (voto >= 10)
        Debug.Log("il voto è A+");
        else if (voto >= 9)
        Debug.Log("il voto è A");
        else if (voto >= 7.8f)
        Debug.Log("il voto è B");
        else if (voto >= 6)
        Debug.Log("il voto è C");
        else if (voto >= 5f)
        Debug.Log("il voto è E");
        else if (voto >= 0.4f)
        Debug.Log("il voto è F");
        else
        Debug.Log("voto non valido");
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
