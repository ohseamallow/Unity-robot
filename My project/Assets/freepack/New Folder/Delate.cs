using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, Random.Range(1, 5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
