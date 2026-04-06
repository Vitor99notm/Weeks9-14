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
		Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

		Vector2 direction = mousePos - (Vector2)transform.position;
		//transform.up = direction;

        Vector2 newPos = transform.position;
		newPos.x += speed * Time.deltaTime;
		newPos.y += speed * Time.deltaTime;
		transform.right = newPos;
        transform.up = newPos;
        transform.position = newPos;

		if (newPos.x >= 16 || newPos.x <= -15)
        {
            speed = 0;
        }

        if (newPos.y >= 7 || newPos.y <= -6.5) 
        {
            speed = 0;
        }

	}
}
