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

    void Update()
    {
        transform.position += (Vector3)movementInput * speed * Time.deltaTime;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
       movementInput = context.ReadValue<Vector2>();
    }

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
}
