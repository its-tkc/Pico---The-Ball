using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountBirds : MonoBehaviour
{
    public static int scoreValue;
    
    public Text txt;

    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0; 
        txt = GetComponent<Text>();
 
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Score:" + scoreValue;
    }
}

