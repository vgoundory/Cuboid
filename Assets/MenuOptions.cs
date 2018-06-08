using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuOptions : MonoBehaviour {

    public AudioMixer audioMixer;

    public void VolumeSetting(float volume) {
        audioMixer.SetFloat("volume", volume);


    }
}
