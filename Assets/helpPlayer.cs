using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class helpPlayer : MonoBehaviour
{

    public AudioSource aS;
    public AudioClip[] aC;

    public float counter;

    public bool playSentece;
    // Start is called before the first frame update
    void Start()
    {
        playSentece = false;
        aS = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;

        if (playSentece)
        {
            if (!aS.isPlaying && counter > 6f)
            {
                aS.clip = aC[Random.Range(0, aC.Length)];
                aS.Play();
                counter = 0;
            }
        }
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playSentece = true;  
        }

    }
    private void OnTriggerExit (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playSentece = false;
        }

    }

}
