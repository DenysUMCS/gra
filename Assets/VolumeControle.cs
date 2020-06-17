using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControle : MonoBehaviour
{
	public UnityEngine.UI.Slider slider;
	public AudioSource volumeAudio;
    void Update()
    {
    	 volumeAudio.volume = slider.value;  
    }
}
