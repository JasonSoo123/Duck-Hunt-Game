using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public float flySpeed, fallSpeed;
    public Animator birdAnimator;
    public Rigidbody2D birdRB;
    public SpriteRenderer birdSprite;
    public bool active;

    void Start()
    {
        active = true;
        while (flySpeed < 2.5f && flySpeed > -2.5f)
        {
            flySpeed = Random.Range(-2.5f, 2.5f);
        }
        if (flySpeed <= 0)
        {
            birdSprite.flipX = true;
        }
        birdRB.velocity = new Vector3(flySpeed, 0, 0);
    }
    void OnMouseUp()
    {
        if (active == true)
        {
            birdAnimator.SetTrigger("Hit");
            GameController.instance.UpdateScore();
            birdRB.velocity = new Vector3(0, -fallSpeed, 0);
        }
        active = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Reset")
        {
            Destroy(this.gameObject);
            GameController.instance.DecreaseLives();
        }
        if (other.gameObject.tag == "ResetBottom")
        {
            Destroy(this.gameObject);
        }

        if (active == true && other.gameObject.tag == "Bullet")
        {
            birdAnimator.SetTrigger("Hit");
            GameController.instance.UpdateScore();
            birdRB.velocity = new Vector3(0, -fallSpeed, 0);
            active = false;  
        }

    }
}
