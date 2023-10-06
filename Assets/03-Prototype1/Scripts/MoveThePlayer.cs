
using UnityEngine;

using UnityEngine.UI;

public class MoveThePlayer : MonoBehaviour
{
    private Rigidbody rg;
    public float speed;
    private float horizontalInput;
    public bool IsOnGround = true;
    private float verticalInput;
    public float jumpForce;
    private int count;
    public Text countText;
    public Text winText;
    public Text notifText;
    
    

    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
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
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        if(other.gameObject.CompareTag("End"))
        {
            if (count >= 30) 
            {
                winText.text = "You Made It!!!!!";
            }
        }
    }
    void SetCountText ()
    {
        countText.text = "Score: " + count.ToString();
        if (count >=30)
        {
            notifText.text = "Head to the goal!";
        }
        
    }

}

