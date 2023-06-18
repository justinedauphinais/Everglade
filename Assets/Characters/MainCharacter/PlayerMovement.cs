using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private SpriteRenderer spriteRenderer;

    [SerializeField] private float moveSpeedWalk = 4f;
    [SerializeField] private float moveSpeedSprint = 7f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxis("Horizontal");
        float dirY = Input.GetAxis("Vertical");

        if (Input.GetKey("left shift"))
        {
            rigidBody.velocity = new Vector2(dirX * moveSpeedSprint, dirY * (moveSpeedSprint / 2));
        }
        else
        {
            rigidBody.velocity = new Vector2(dirX * moveSpeedWalk, dirY * (moveSpeedWalk / 2));
        }
    }
}
