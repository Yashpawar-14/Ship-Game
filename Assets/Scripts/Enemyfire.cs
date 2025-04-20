using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyfire : MonoBehaviour
{
    public GameObject GameObject;

    private bool hasShot = false;


    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(2f);

        if (!hasShot)
        {
            Instantiate(gameObject, transform.position , Quaternion.identity);
            hasShot = true;
        }

    }
}
