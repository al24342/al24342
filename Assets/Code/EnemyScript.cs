using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update

    public int Speed = -5;
    Rigidbody2D r2d;
    void Start()
    {

        r2d = GetComponent<Rigidbody2D>();

        Vector2 vel = r2d.velocity;
        vel.y = Speed;
        r2d.velocity = vel;


        r2d.angularVelocity = Random.Range(-200, 200);

    }

    // Update is called once per frame
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        var name = other.gameObject.name;
        
        if (name == "bullet(Clone)")
        { Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else if (name == "player")
        { Destroy(gameObject); }
    }



}
