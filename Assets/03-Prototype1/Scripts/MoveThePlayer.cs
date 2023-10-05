using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveThePlayer : MonoBehaviour
{
    private Rigidbody rg;
    public float speed;
    private float horizontalInput;
    public bool IsOnGround = true;
    private float verticalInput;
    public float jumpForce;
    

    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(Physics.gravity*4f, ForceMode.Acceleration);
    }
    void Update()
    { 
        // player inputs
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");

        // move the player
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        // jump
        if (Input.GetKeyDown(KeyCode.Space) && IsOnGround)
        {
            rg.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            IsOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsOnGround = true;
        }
    }
}
