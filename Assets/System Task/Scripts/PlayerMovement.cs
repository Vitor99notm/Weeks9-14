using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public bool isKeyPressed;
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //CHANGE
        //SCRIPT
        //TO BE
        //UNITY'S MOVEMENT SYSTEM!!!!
    }

    // Update is called once per frame
    void Update()
    {
        //Check if key was pressed
        //isKeyPressed = Keyboard.current.anyKey.isPressed;

        //Up key makes character go up
        if (Keyboard.current.upArrowKey.isPressed)
        {
            Vector2 newPos = transform.position;
            newPos.y += speed * Time.deltaTime;
            transform.position = newPos;
        }
        //Down key makes character go down
        if (Keyboard.current.downArrowKey.isPressed)
        {
            Vector2 newPos = transform.position;
            newPos.y -= speed * Time.deltaTime;
            transform.position = newPos;
        }
        //Left kay makes character go left
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            Vector2 newPos = transform.position;
            newPos.x -= speed * Time.deltaTime;
            transform.position = newPos;
        }
        //Right key makes character go right
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            Vector2 newPos = transform.position;
            newPos.x += speed * Time.deltaTime;
            transform.position = newPos;
        }
    }
}
