using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fly : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        
    }
    void Update()
    {
        rb = this.GetComponent<Rigidbody2D>();
        if (Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = new Vector2(0, 5f);
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.Mouse1))
        {
            rb.velocity = new Vector2(0, -3f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Hole")
        {
            score.ScoreValue = 0;
            SceneManager.LoadScene("SampleScene");
        }    
    }
}
