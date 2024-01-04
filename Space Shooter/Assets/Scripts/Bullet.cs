using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 2f;

    void Start()
    {
        // Set the bullet to destroy itself after a certain amount of time
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        // Move the bullet upward along the Y-axis
        transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Destroy the bullet if it collides with something
        //Destroy(gameObject);
        Debug.Log(other.gameObject.name);
    }
}