using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int Speed = 5;

    Rigidbody2D r2d;
    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        Vector2 vel = r2d.velocity;
        vel.y = Speed;
        r2d.velocity = vel;
    }
    void OnBecameInvisible() {
        //Destroy the object
        Destroy(gameObject);
    }

}
