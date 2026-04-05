using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{

	//Spawner components

	public GameObject zombiePrefab;
	public GameObject spawnedZombie;
	public float timeV = 0;
	public float timeMV = 5;

	public Zombie zombieScript;

	void Start()
    {
        
    }

    void Update()
    {
		timeV += Time.deltaTime;


		Vector2 randomPos = transform.position;

		//Spawn new zombie code
		if (timeV > timeMV)
		{
			//Spawns the zombies
			spawnedZombie = Instantiate(zombiePrefab, transform.position, transform.rotation);

			zombieScript = spawnedZombie.GetComponent<Zombie>();
			timeV = 0;

			//Sets a random position for the spawner
			randomPos.x = Random.Range(12, -12);
			randomPos.y = Random.Range(5, -6);
			transform.position = randomPos;
		}
	}
}
