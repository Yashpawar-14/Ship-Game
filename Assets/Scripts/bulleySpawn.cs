using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulleySpawn : MonoBehaviour
{
    public GameObject bulleySpawnPrefab;



    public void Bulletspawn()
    {
        Instantiate(bulleySpawnPrefab, transform.position , Quaternion.identity);
    }

}
