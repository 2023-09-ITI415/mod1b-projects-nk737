using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
//using FSharp.Compiler.Text;
using UnityEditor;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class AppleTree : MonoBehaviour {
    [Header("Set in Inspector")]
    // Prefab for instantiating apples
    public GameObject applePrefab;

    // speed of apple tree
    public float speed = 1f;

    // Turn around distance
    public float leftAndRightEdge = 10f;

    // chance of changing directions
    public float chanceToChangeDirections = 0.1f;

    // instantiation rate
    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
        // Dropping apples every second
        Invoke("DropApple", 2f); // a
    }

    void DropApple()
    { // b
        GameObject apple = Instantiate<GameObject>(applePrefab); // c
        apple.transform.position = transform.position; // d
        Invoke("DropApple", secondsBetweenAppleDrops); // e
    }




    // Update is called once per frame


    void Update() {
            // basic movement 
            Vector3 pos = transform.position; //b
            pos.x += speed * Time.deltaTime; // c
            transform.position = pos; //d
                                      // Changing Direction
        if (pos.x >= -leftAndRightEdge)
        {
            if (pos.x > leftAndRightEdge)
            {
                speed = -Mathf.Abs(speed); // Move left
            } // a
        }
        else
        {
            speed = Mathf.Abs(speed); // Move right
        }
    }
        void FixedUpdate()
    {
        // Changing Direction Randomly is now time-based because of
        // FixedUpdate()
    if (Random.value < chanceToChangeDirections)
        { // b
            speed *= -1; // Change direction
        }


    }
        }
    






        
    

