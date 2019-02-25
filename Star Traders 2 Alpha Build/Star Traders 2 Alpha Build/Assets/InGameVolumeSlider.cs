using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class InGameVolumeSlider : MonoBehaviour
{
    public AudioMixer master;

    public Slider volumeSlider;
    public float volumeSliderValue;
    // Start is called before the first frame update
    void Start()
    {
        volumeSliderValue = volumeSlider.value;
    }
    public void SetSound(float soundlevel)
    {
        master.SetFloat("master", soundlevel);
    }
    
}
