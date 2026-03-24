using System.Collections.Generic;
using UnityEngine;

public class RandomSFX : MonoBehaviour
{
    //SFX Template
    public AudioSource SFX;
    //List for differnt SFX
    public List<AudioClip> SFXRandom;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void randomSFX() 
    {
        //Pick between the different clips on the list and apply it to the template.
        SFX.clip = SFXRandom[Random.Range(0, 3)];
        SFX.Play();
    }
}
