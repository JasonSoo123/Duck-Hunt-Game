using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    public GameObject bomb;
    public float SpawnX;
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
            SpawnX = Random.Range(-8.30f, 8.30f);
            Instantiate(bomb, new Vector3(SpawnX, transform.position.y, 0), transform.rotation);
        }
    }
}
