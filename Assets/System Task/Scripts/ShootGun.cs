using UnityEngine;
using UnityEngine.InputSystem;

public class ShootGun : MonoBehaviour
{
    public float speed = 3f;
    public Transform gunPos;

    //public Transform bulletPos;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 bulletPos = transform.position;
        bulletPos.z = gunPos.transform.position.z * speed * Time.deltaTime;
        transform.position = bulletPos;
        transform.position += transform.up * speed * Time.deltaTime;
    }

    
}
