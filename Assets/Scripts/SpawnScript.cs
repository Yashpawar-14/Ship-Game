using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public GameObject Enemy;
    public float spawnDelay = 5f; // normal delay between spawns
    public float initialDelayMin = 0f; // minimum random delay
    public float initialDelayMax = 3f; // maximum random delay

    private void Start()
    {
        StartCoroutine(SpawnWithDelay());
    }

    private IEnumerator SpawnWithDelay()
    {
        // Random first delay to desync spawns
        float randomStartDelay = Random.Range(initialDelayMin, initialDelayMax);
        yield return new WaitForSeconds(randomStartDelay);

        while (true)
        {
            Instantiate(Enemy, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}