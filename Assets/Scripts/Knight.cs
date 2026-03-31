using Unity.Cinemachine;
using UnityEngine;

public class Knight : MonoBehaviour
{
    public AudioSource SFX;
    public CinemachineImpulseSource impulseSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FootStep() 
    {
        //Debug.Log("FootStep");
        SFX.Play();
        impulseSource.GenerateImpulse();
    }
}
