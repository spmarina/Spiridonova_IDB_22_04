using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public int score = 100;
    public void OnCollisionEnter()
    {
        Debug.Log("True");
        score = score - 1;
    }



    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
