using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float speed = 10f;
    [SerializeField] GameObject bullet;
    [SerializeField] float bulletSpeed = 10f;
    [SerializeField] Transform newParent;
    [SerializeField] Transform firePoint;

    private GameObject bulletObject;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if (Input.GetButton("Fire1"))
        {
            Invoke("GetBulletObject", 1f); 
            bulletObject.transform.parent = newParent;
            Rigidbody rb = bulletObject.GetComponent<Rigidbody>();
            rb.AddForce(firePoint.up * bulletSpeed, ForceMode.Impulse);
        }
    }

    private void GetBulletObject()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }

    private void Movement()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.GetAxis("Mouse X") > 0)
            {
                //Code for action on mouse moving left
                rb.AddForce(new Vector3(speed, 0, 0));
                //print("Mouse moved left");
            }
            if (Input.GetAxis("Mouse X") < 0)
            {
                //Code for action on mouse moving right
                rb.AddForce(new Vector3(-speed, 0, 0));
                //print("Mouse moved right");
            }
        }
    }
}
