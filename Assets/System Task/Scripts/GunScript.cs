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
        //Makes barrel of gun follow player mouse
		Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector2 direction = mousePos - (Vector2)transform.position;
        transform.up = direction;


	}

    //OnShoot action to allow player to shoot bullets
    public void OnShoot(InputAction.CallbackContext context)
    {
        //Spawns in bullets
        if (context.performed == true)
        {
            //Sets the position/rotation of bullet so it shoots in the correct direction that player aimed
            spawnedBullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            spawnedBullet.GetComponent<ShootGun>().gunPos = bullet;

            SFX.Play();
        }
    }


}
