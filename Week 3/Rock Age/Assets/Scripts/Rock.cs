using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    // Start is called before the first frame update
    // a method for initializing variables, works onc

    void Start()
    {
        float angel = Random.Range(0, Mathf.PI * 2);
        const float minpulse = 2;
        const float maxpulse = 5;

        // get a random destination
        Vector2 direction = new Vector2(Mathf.Cos(angel), Mathf.Sin(angel));

        // random magnitude
        float magnitude = Random.Range(minpulse, maxpulse);

        // adding force to the object
        Rigidbody2D rb2d;
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(direction * magnitude, ForceMode2D.Impulse);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);

    }
}
