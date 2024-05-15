using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stepsSound : MonoBehaviour
{
    public AudioSource aS;
    public AudioClip[] steps;
    public AudioClip[] waterSteps;
    public AudioClip[] stoneSteps;
    public AudioClip[] woodSteps;

    public int type;

    public CapsuleCollider playerColl;
    // Start is called before the first frame update
    void Start()
    {
        aS = GetComponent<AudioSource>();
        playerColl = GetComponent<CapsuleCollider>();
        type = 1;
    }


    void Step()
    {
        if (type == 1) { 
            GrassStep();
        }
        if (type == 2)
        {
            WaterStep();
        }
        if (type == 3)
        {
            StoneStep();
        }
        if (type == 4)
        {
            WoodStep();
        }
    }

    void GrassStep() 
    {
        aS.clip = steps[Random.Range(0, steps.Length)];
        aS.pitch = Random.Range(0.8f, 1.2f);
        aS.volume = Random.Range(0.8f, 1.2f);
        aS.Play();
    
    }
    void WaterStep()
    {
        aS.clip = waterSteps[Random.Range(0, waterSteps.Length)];
        aS.pitch = Random.Range(0.8f, 1.2f);
        aS.volume = Random.Range(0.8f, 1.2f);
        aS.Play();

    }

    void StoneStep()
    {
        aS.clip = stoneSteps[Random.Range(0, stoneSteps.Length)];
        aS.pitch = Random.Range(0.8f, 1.2f);
        aS.volume = Random.Range(0.8f, 1.2f);
        aS.Play();

    }

    void WoodStep()
    {
        aS.clip = woodSteps[Random.Range(0, woodSteps.Length)];
        aS.pitch = Random.Range(0.8f, 1.2f);
        aS.volume = Random.Range(0.8f, 1.2f);
        aS.Play();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("water"))
        {
            type = 2;
        }
        if (other.gameObject.CompareTag("grass"))
        {
            type = 1;
        }
        if (other.gameObject.CompareTag("stone"))
        {
            type = 3;
        }
        if (other.gameObject.CompareTag("wood"))
        {
            type = 4;
        }
    }
}
