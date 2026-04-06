using UnityEngine;
using UnityEngine.InputSystem;

public class GunScript : MonoBehaviour
{
    public Transform gunBarrel;

    public GameObject bulletPrefab;
    public GameObject spawnedBullet;

    public Transform bullet;
    public ShootGun shootGun;

    public AudioSource SFX;

    void Start()
    {
        
    }

    void Update()
    {
		Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        Vector2 direction = mousePos - (Vector2)transform.position;
        transform.up = direction;


	}

    public void OnShoot(InputAction.CallbackContext context)
    {
        //Debug.Log("Attack " + context.phase);
        if (context.performed == true)
        {
            spawnedBullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            spawnedBullet.GetComponent<ShootGun>().gunPos = bullet;

            SFX.Play();
        }
    }


}
