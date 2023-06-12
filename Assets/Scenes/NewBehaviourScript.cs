using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int publicNum;
    private int privateNum;

    // ...
    void Awake()
    {
        UnityEngine.Debug.Log("Awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Debug.Log("Update");
    }

    // ...
    void FixedUpdate()
    {
        UnityEngine.Debug.Log("Fixed Update");
    }
}
