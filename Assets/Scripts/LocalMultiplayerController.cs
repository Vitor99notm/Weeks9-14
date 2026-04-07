using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class LocalMultiplayerController : MonoBehaviour
{
    //Variable to allow LocalMultiplayerManager to access this script
    public LocalMultiplayerManager manager;
    public PlayerInput playerInput;

    //Transform for the attacking Coroutine
    public Transform playerScale;

    //Movement varibales for player
    public Vector2 movementInput;
    public float speed = 5f;

    //Using an animation curve lets you set up when a scale ends and starts
    public AnimationCurve playerCurve;
    public AudioSource attackSound;

    Coroutine thePlayerAttackCoroutine;
    Coroutine thePlayerDashCoroutine;

    void Update()
    {
        //Movement for player
        
        transform.position += (Vector3)movementInput * speed * Time.deltaTime;

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        //When WASD/Controller pad is pressed move player
       movementInput = context.ReadValue<Vector2>();
    }

    //Makes player attack another player
    public void OnAttack(InputAction.CallbackContext context) 
    {
        if (context.performed) 
        {
            if(thePlayerAttackCoroutine != null)
            {
                StopCoroutine(thePlayerAttackCoroutine);
            }
            Debug.Log("Player " + playerInput.playerIndex + ": attacked!");
            manager.PlayerAttacking(playerInput);
            attackSound.Play();

            thePlayerAttackCoroutine = StartCoroutine(StartAttack());
        }
        
    }

    //Makes player go faster when pressed
    public void OnDash(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (thePlayerDashCoroutine != null) 
            {
                StopCoroutine(thePlayerDashCoroutine);
            }
            Debug.Log("PLAYER " + playerInput.playerIndex + " IS GOING FAST");
            thePlayerDashCoroutine = StartCoroutine(PlayerDash());

        }

    }

    IEnumerator StartAttack()
    {
        float t = 0;

        while(t < 2)
        {
            t += Time.deltaTime;
            playerScale.transform.localScale = Vector3.one * playerCurve.Evaluate(t);
            yield return null;

        }

    }

    IEnumerator PlayerDash()
    {
        float t = Time.deltaTime;

        while (t < 1)
        {
            speed = speed + 10;
            if (t >= 1)
            {
                speed = 5;
                t = 0;
                yield return new WaitForSeconds(speed);
            }
            
        }
    }
}
