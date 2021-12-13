using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public AudioSource source;
    public Slider slider;
    public string SourceName;
    
    void Start(){
        slider.value = PlayerPrefs.GetFloat(SourceName, 0.75f);
    }
    public void SetLevel(float SliderValue){
        mixer.SetFloat(SourceName, Mathf.Log10(SliderValue)*20);
        PlayerPrefs.SetFloat(SourceName, SliderValue);;
       
    }
    public void PlayVolumeCheck(){
            AudioSource.PlayClipAtPoint(source.clip, new Vector2(0,0));

    }
}
