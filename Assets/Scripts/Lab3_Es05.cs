using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_Es05 : MonoBehaviour
{
    public int partenza = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(partenza);
        Debug.Log(++partenza);
        Debug.Log(++partenza);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
