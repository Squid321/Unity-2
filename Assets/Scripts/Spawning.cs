using UnityEngine;

public class Spawning : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Spawn", startDelay, spawnDelay);
    }

    // Update is called once per frame
    public GameObject[] animalPrefabs;
    private float startDelay = .5f;
    private float spawnDelay = 1.1f;
    
    void Update()
    {

    }
    void Spawn()
    {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], new Vector3(Random.Range(-16, 16), 0, 20),
            animalPrefabs[animalIndex].transform.rotation);
    }
}
