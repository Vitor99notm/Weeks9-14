using UnityEngine;
using UnityEngine.InputSystem;

public class ShootGun : MonoBehaviour
{
    public float speed = 3f;

    //public Transform bulletPos;

    void Start()
    {
        
    }

    void Update()
    {
		Vector2 bulletPos = transform.position;
        transform.position += transform.up * speed * Time.deltaTime;

	}
}
