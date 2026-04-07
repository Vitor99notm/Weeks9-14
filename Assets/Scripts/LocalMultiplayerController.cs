using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class LocalMultiplayerController : MonoBehaviour
{
    public LocalMultiplayerManager manager;
    public PlayerInput playerInput;
    public Transform playerScale;
    public Vector2 movementInput;
    public float speed = 5f;

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
            //scale = t * -1;
            playerScale.transform.localScale = Vector3.one * playerCurve.Evaluate(t);
            yield return null;

        }



    }
}
