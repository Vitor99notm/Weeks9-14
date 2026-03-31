using UnityEngine;
using UnityEngine.InputSystem;

public class CharMovement : MonoBehaviour
{
    public bool isKeyPresed;
    public float speed = 0.05f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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

