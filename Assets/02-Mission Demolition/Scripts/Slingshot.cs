using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour

{
    // fields set in the Unity Inspector pane
    [Header("Set in Inspector")] // a
    public GameObject prefabProjectile;
    // fields set dynamically
    [Header("Set Dynamically")] // a

    public GameObject launchPoint;
    public Vector3 launchPos; // b
    public GameObject projectile; // b
    public bool aimingMode; // b
    void Awake()
    {
        Transform launchPointTrans = transform.Find("LaunchPoint"); // a
        launchPoint = launchPointTrans.gameObject;
        launchPoint.SetActive(false); // b
        launchPos = launchPointTrans.position; // c
    }
    void OnMouseEnter()
    {

        //print("Slingshot:OnMouseEnter()");
        launchPoint.SetActive(true); // b
    }
    void OnMouseExit()
    {
        //print("Slingshot:OnMouseExit()");
        launchPoint.SetActive(false); // b
    }
    // Start is called before the first frame update
    void OnMouseDown()
    { // d
      // The player has pressed the mouse button while over Slingshot
        aimingMode = true;
        // Instantiate a Projectile
        projectile = Instantiate(prefabProjectile) as GameObject;
        // Start it at the launchPoint
        projectile.transform.position = launchPos;
        // Set it to isKinematic for now
        projectile.GetComponent<Rigidbody>().isKinematic = true;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
