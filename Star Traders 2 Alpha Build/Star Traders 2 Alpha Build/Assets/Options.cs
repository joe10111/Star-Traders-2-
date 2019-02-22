using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public Slider volumeSlider;

    public AudioSource volumeAudio;

    public void VolumeController()
    {
        volumeAudio.volume = volumeSlider.value;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
