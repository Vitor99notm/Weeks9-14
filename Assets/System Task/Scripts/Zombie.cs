using UnityEngine;

public class Zombie : MonoBehaviour
{

    //Keeps track of the players current position so that later code can use it to make zombie follow the player
    public Transform playerPos;
    public float speed = 1f;

    

    void Start()
    {
        
    }

    void Update()
    {

        //Calculates the player position - the zombie position and makes the zombie follow the player
		Vector2 direction = playerPos.position - transform.position;
        transform.position += (Vector3)direction * speed * Time.deltaTime;
        
        
    }
}
