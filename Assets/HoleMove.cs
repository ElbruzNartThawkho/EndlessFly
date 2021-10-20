using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleMove : MonoBehaviour
{
    private float speed=5f;
    private Rigidbody2D rb;
    void Start()
    {

    }
    void FixedUpdate()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-5f,0);
        DeleteHole();
    }
    private void DeleteHole()
    {
        if (rb.transform.position.x < -13) 
        {
            Destroy(this.gameObject);
        }
    }
}
