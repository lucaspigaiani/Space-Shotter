using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;

    void Update()
    {
        // Shooting
        if (Input.GetButtonDown("Fire1"))  // "Fire1" is the left mouse button by default
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instantiate a bullet at the firePoint position and rotation
        Instantiate(bulletPrefab, firePoint.position, bulletPrefab.transform.rotation);
    }
}