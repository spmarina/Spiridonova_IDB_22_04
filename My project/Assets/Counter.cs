using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text TextCounter;
    public Collision CubeScript;

    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        TextCounter.text = "Score: " + CubeScript.score;
    }
}
