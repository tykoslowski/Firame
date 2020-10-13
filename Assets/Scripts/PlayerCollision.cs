using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; // A reference to our PlayerMovement script.

    // This function runs when we hit an object. We get information about the collision and call it "collisioninfo".
    void OnCollisionEnter(Collision collisionInfo)
    {
        // We check if the object we collided with has a tag called "Obstacle".
        if (collisionInfo.collider.tag == "Obstacle")
        {
            GetComponent<PlayerMovement>().enabled = false; // Disable player movement.
            FindObjectOfType<GameManager>().EndGame();
        }
        
        // We check if the object we collided with has a tag called "Ground".
        if (collisionInfo.collider.tag == "Ground")
        {
            movement.canJump = true; // Give the player the ability to jump.
        }
    }
}
