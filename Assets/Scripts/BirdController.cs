using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public GameObject bird1, bird2, bird3, bird4;
    public int dice, birdNumber;
    public int diceMax;
    float timer;

    void Start()
    {
        diceMax = 400;
        timer = 0;
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 20)
        {
            diceMax = 300;
        }
        if (timer >= 40)
        {
            diceMax = 185;
        }
        if (timer >= 90)
        {
            diceMax = 100;
        }

        dice = Random.Range(1, diceMax);

        if (dice == 1)
        {
            float ySpawn = Random.Range(-2.5f, 3.75f);
            birdNumber = Random.Range(1, 5);
            if (birdNumber == 1)
            {
                Instantiate(bird1, new Vector3(transform.position.x, ySpawn, 0), transform.rotation);
            }
           
            if (birdNumber == 2)
            {
                Instantiate(bird2, new Vector3(transform.position.x, ySpawn, 0), transform.rotation);
            }
            
            if (birdNumber == 3)
            {
                Instantiate(bird3, new Vector3(transform.position.x, ySpawn, 0), transform.rotation);
            }
            
            if (birdNumber == 4)
            {
                Instantiate(bird4, new Vector3(transform.position.x, ySpawn, 0), transform.rotation);
            }
           

        }
    }
}
