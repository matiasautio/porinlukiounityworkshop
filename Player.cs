using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength = 10;
    public GameManager gameManager;
    private bool canPlay = true;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && canPlay == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canPlay = false;
        gameManager.GameOver();
    }
}
