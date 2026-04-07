using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{

	//Spawner components
	public GameObject zombiePrefab;
	public GameObject spawnedZombie;

	public Transform player;
	public Transform bullet;

	public GunScript g;

	public Zombie zombieScript;

    public float timeV = 0;
    public float timeMV = 5;

    void Start()
    {
		bullet = (Transform)g.spawnedBullet.transform;

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

			spawnedZombie.GetComponent<Zombie>().playerPos = player;
			spawnedZombie.GetComponent<Zombie>().bulletPos = bullet;

			
			//Resets Timer
			timeV = 0;

			//Sets a random position for the spawner
			randomPos.x = Random.Range(12, -12);
			randomPos.y = Random.Range(5, -6);
			transform.position = randomPos;


		}

	}
}
