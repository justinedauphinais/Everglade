using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class PlayerMouvement : MonoBehaviour
{
    private Vector2 speedWalk = new Vector2(3, 1.5f);
    private Vector2 speedRunning = new Vector2(6, 3);

    private GameObject tilemapCollision;

    // Start is called before the first frame update
    void Start()
    {
        tilemapCollision = GameObject.Find("Collision");
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(speedWalk.x * inputX, speedWalk.y * inputY, 0);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            movement = new Vector3(speedRunning.x * inputX, speedRunning.y * inputY, 0);
        }

        movement *= Time.deltaTime;

        transform.Translate(movement);
    }

    void OnCollisionEnter(Collision collision)
    {
        UnityEngine.Debug.Log("Collision!");
    }
}
