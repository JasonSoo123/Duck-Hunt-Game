using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    public GameObject heart;
    public float spawnX;
    public int dice, diceMax;

    void Start()
    {
        dice = 0;
    }

    void Update()
    {
        dice = Random.Range(1, diceMax);
        if (dice == 1)
        {
            spawnX = Random.Range(-8.30f, 8.30f);
            Instantiate(heart, new Vector3(spawnX, transform.position.y, 0), transform.rotation);
        }

    }
}
