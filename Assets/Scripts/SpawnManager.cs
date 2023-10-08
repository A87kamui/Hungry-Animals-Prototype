using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    //***Bonus feature***
    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;
    public float sideSpawnX;

    // Start is called before the first frame update
    void Start()
    {
        //Calls a method, start time in second, rate to repeat
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);

        //***Bonus feature***
        InvokeRepeating("SpawnLeftAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRightAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        //Rnadomly generate animal index and spawn position
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        //Random selects a number between 0-3 but not including 3
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        //Creates copies of animals 
        Instantiate(animalPrefabs[animalIndex], spawnpos, animalPrefabs[animalIndex].transform.rotation);
    }

    //***Bonus feature***
    void SpawnLeftAnimal()
    {
        //Random selects a number between 0-3 but not including 3
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        //Randomly generate animal index and spawn position
        Vector3 spawnpos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));

        //Update rotation (orientation) of animal
        Vector3 rotation = new Vector3(0, 90, 0);

        //Creates copies of animals
        ////Quaternion = use to represent rotation
        //Quaternion.Euler uses (x, y, z) to return rotation x degrees on x-axis, y degrees on y-asix, z degress on z-axis
        Instantiate(animalPrefabs[animalIndex], spawnpos, Quaternion.Euler(rotation));
    }

    void SpawnRightAnimal()
    {
        //Random selects a number between 0-3 but not including 3
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        //Randomly generate animal index and spawn position
        Vector3 spawnpos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));

        //Update rotation (orientation) of animal
        Vector3 rotation = new Vector3(0, -90, 0);

        //Creates copies of animals
        ////Quaternion = use to represent rotation
        //Quaternion.Euler uses (x, y, z) to return rotation x degrees on x-axis, y degrees on y-asix, z degress on z-axis
        Instantiate(animalPrefabs[animalIndex], spawnpos, Quaternion.Euler(rotation));
    }
}
