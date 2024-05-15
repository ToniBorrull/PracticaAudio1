using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class EnviromentChange : MonoBehaviour
{
    public AudioMixerSnapshot Epic1;
    public AudioMixerSnapshot Epic2;
    public AudioMixerSnapshot Epic3;
    public AudioMixerSnapshot noMusic;
    public AudioMixerSnapshot pubWalla;
    public AudioMixerSnapshot tenseMus;
    public AudioMixerSnapshot japaneseMus;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Epic3")
            Epic3.TransitionTo(0.5f); 
        
        if (other.gameObject.tag == "Epic2")
            Epic2.TransitionTo(0.5f); 
        
        if (other.gameObject.tag == "Epic1")
            Epic1.TransitionTo(0.5f);

        if (other.gameObject.tag == "pub")
            pubWalla.TransitionTo(0.5f);

        if (other.gameObject.tag == "tense")
            tenseMus.TransitionTo(0.5f);

        if (other.gameObject.tag == "japanese")
            japaneseMus.TransitionTo(0.5f);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Epic3")
            noMusic.TransitionTo(0.5f);

        if (other.gameObject.tag == "Epic2")
            Epic3.TransitionTo(0.5f);

        if (other.gameObject.tag == "Epic1")
            Epic2.TransitionTo(0.5f);

        if (other.gameObject.tag == "pub")
            noMusic.TransitionTo(0.5f);

        if (other.gameObject.tag == "tense")
            noMusic.TransitionTo(0.5f);

        if (other.gameObject.tag == "japanese")
            noMusic.TransitionTo(0.5f);
    }

}
