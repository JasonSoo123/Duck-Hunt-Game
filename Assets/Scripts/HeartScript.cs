using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{
    public float fallSpeed;
    public Rigidbody2D heartRB;

    void Start()
    {
        fallSpeed = -3.0f;
        fallSpeed = Random.Range(-3.5f, -3f);
        heartRB.velocity = new Vector3(0, fallSpeed, 0);
    }
    void OnMouseUp()
    {
        GameController.instance.IncreaseLives();
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
