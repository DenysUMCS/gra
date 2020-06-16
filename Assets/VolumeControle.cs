using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControle : MonoBehaviour
{
    // Start is called before the first frame update
   	public Audio Sound; 
    // Update is called once per frame
    void Update()
    {
        Sound.Volume = Volume;
    }
}
