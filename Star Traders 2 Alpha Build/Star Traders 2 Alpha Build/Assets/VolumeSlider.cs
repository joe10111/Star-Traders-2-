using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;



public class VolumeSlider : MonoBehaviour
{
    public Slider Volume;
    public AudioMixer myMusic;

    public void SoundChange(float soundLevel)
    {
        myMusic.SetFloat("masterVol" , soundLevel);
    }
}
