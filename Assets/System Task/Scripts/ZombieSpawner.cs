using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
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

		//Spawn new zombie code
		if (timeV > timeMV)
		{
			zombiePrefab = Instantiate(zombiePrefab, transform.position, transform.rotation);
			timeV = 0;
		}
	}
}
