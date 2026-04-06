using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerInput : MonoBehaviour
{
    public float speed = 5;
    public Vector2 movement;
    public Animator playerAnimator;
    public AudioSource SFX;

    public GameObject bulletPrefab;
    public GameObject spawnedBullet;
    public ShootGun gunScript;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)movement * speed * Time.deltaTime;
        //transform.position = movement;

    }

    public void OnMove(InputAction.CallbackContext context)
    {
       movement = context.ReadValue<Vector2>();
       //playerAnimator.SetBool("isRunning", true);
    }


    public void OnAttack(InputAction.CallbackContext context) 
    {
        //Debug.Log("Attack " + context.phase);
        if (context.performed == true)
        {
            spawnedBullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            gunScript = spawnedBullet.GetComponent<ShootGun>();

            SFX.Play();
        }
    }

    public void OnPoint(InputAction.CallbackContext context) 
    {
        //Same as Mouse.current.position.ReadValue()
        movement = Camera.main.ScreenToWorldPoint(context.ReadValue<Vector2>());
    }
}
