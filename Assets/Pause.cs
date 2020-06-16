using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    Text score;
    public static bool isPause=false;
    void Start()
    {
    	isPause=!isPause;
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
