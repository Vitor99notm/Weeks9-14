using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
	//public Transform playerPos;
	//public float speed = 1f;

	//Spawner components

	public GameObject zombiePrefab;
	public float timeV = 0;
	public float timeMV = 5;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		timeV += Time.deltaTime;
		//Vector2 direction = playerPos.position - transform.position;
		//transform.position += (Vector3)direction * speed * Time.deltaTime;
		//Spawn new zombie code
		if (timeV > timeMV)
		{
			zombiePrefab = Instantiate(zombiePrefab, transform.position, transform.rotation);
			timeV = 0;
		}
	}
}
