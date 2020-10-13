using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the GameManager called gameManager.
    //public GameManager gameManager;

    // This is a reference to the Rigidbody component called "rb".
    public Rigidbody rb;

    // This is the delay before the level restarts.
    //float restartDelay = 0.3f;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpForce = 300f;

    // We marked this as "fixed"Update because we are using it to mess with physics.
    public bool canJump = false;
    void FixedUpdate()
    {
        // Add a forward force.
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("space"))
        {
            if (canJump)
            {
                rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
                canJump = false;
            }
        }

        if (rb.position.y < -0.3f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
        //// If the player presses "r" then the level will restart.
        //if (Input.GetKey("r"))
        //{
        //    Invoke("gameManager.Restart", restartDelay);
        //}
    }
}
