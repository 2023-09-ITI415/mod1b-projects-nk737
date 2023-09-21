using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEditor;
using UnityEngine;

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
        
    }

    // Update is called once per frame
    

        void Update() {
            // basic movement 
            Vector3 pos = transform.position; //b
            pos.x += speed * Time.deltaTime; // c
            transform.position = pos; //d
        }
    
        
    }

