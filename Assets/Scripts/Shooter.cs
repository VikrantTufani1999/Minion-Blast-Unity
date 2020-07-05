using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    [SerializeField] Transform newParent;

    bool isFiring = false;

    public float bulletForce = 20f;
    
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            isFiring = true;
            if (isFiring)
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet.transform.parent = newParent;
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
