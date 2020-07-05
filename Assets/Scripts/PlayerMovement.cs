using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.GetAxis("Mouse X") > 0)
            {
                //Code for action on mouse moving left
                rb.AddForce(new Vector3(10, 0, 0));
                //print("Mouse moved left");
            }
            if (Input.GetAxis("Mouse X") < 0)
            {
                //Code for action on mouse moving right
                rb.AddForce(new Vector3(-10, 0, 0));
                //print("Mouse moved right");
            }
        }
    }
}
