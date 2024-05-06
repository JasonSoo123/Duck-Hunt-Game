using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    public float fallSpeed;
    public Rigidbody2D bombRB;

    void Start()
    {
        fallSpeed = -3.0f;
        fallSpeed = Random.Range(-3.5f, -3.0f);
        bombRB.velocity = new Vector3(0, fallSpeed, 0);
    }
    void OnMouseUp()
    {
        GameController.instance.DecreaseLives();
        Destroy(this.gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ResetBottom")
        {
            Destroy(this.gameObject);
        }
    }
}
