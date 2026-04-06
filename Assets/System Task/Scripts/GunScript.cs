using UnityEngine;
using UnityEngine.InputSystem;

public class GunScript : MonoBehaviour
{
    public GameObject gunBarrel;

	void Start()
    {
        
    }

    void Update()
    {
		Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        Vector2 direction = mousePos - (Vector2)transform.position;
        transform.up = direction;


	}


}
