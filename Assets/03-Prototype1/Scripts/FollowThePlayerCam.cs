
using UnityEngine;

public class FollowThePlayerCam : MonoBehaviour
{
    public GameObject player;
    public float cameraDistance = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void LateUpdate()
    {
        transform.position = player.transform.position - player.transform.forward * cameraDistance;
        transform.LookAt(player.transform.position);
        transform.position = new Vector3(transform.position.x, transform.position.y+60, transform.position.z);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
