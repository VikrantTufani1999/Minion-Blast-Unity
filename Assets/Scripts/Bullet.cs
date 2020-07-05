using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject ballPrefab;
    [SerializeField] Transform ballParent;

    //float count = 0f;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Minion")
        {
            //Debug.Log("HIT");
            Destroy(gameObject);
            //Destroy(GameObject.Find("Minion Ball"));
            //count = 1f;
            spawn();
        }
    }

    void spawn()
    {
        //if (count == 1)
        //{
            GameObject ball = Instantiate(ballPrefab, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
            ball.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            ball.transform.parent = ballParent;
            //count = 0f;
        //}
    }
}
