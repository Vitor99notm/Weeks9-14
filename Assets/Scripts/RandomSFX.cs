using System.Collections.Generic;
using UnityEngine;

public class RandomSFX : MonoBehaviour
{

    public AudioSource SFX;
    public List<AudioClip> SFXRandom;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void randomSFX() 
    {
        SFX.clip = SFXRandom[Random.Range(0, 3)];
        SFX.Play();
    }
}
