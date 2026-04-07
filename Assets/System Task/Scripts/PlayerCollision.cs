using UnityEngine;
using UnityEngine.Events;

public class PlayerCollision : MonoBehaviour
{
    public float PlayerHealth = 3;
    public GameObject playerPos;
    //public Transform zombiePos;

    public ZombieSpawner z;

    public UnityEvent PlayerCN;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(playerPos.transform.position, z.spawnedZombie.transform.position);

        if (distance < 0.8)
        {
            PlayerCN.Invoke();
        }
    }

    public void playerHealth()
    {
        PlayerHealth = PlayerHealth - 1;
        Debug.Log(PlayerHealth);
    }
}
