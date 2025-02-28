using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Set up camera
    public GameObject player;
    private Vector3 offset = new Vector3(0, 8, -15);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset the camera behin the player by adding the player's position
        transform.position = player.transform.position + offset;
    }
}
