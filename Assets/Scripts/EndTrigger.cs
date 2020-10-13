using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    // Detects when an object marked "Is trigger" is collided with.
    void OnTriggerEnter(Collider triggerer)
    {
        // If the triggerer is the Player, then complete the level.
        if (triggerer.tag == "Player")
        {
            gameManager.CompleteLevel();
        } 
    }

    void OnTriggerExit(Collider triggerer)
    {
        // If the triggerer is the Player, then stop its motion.
        if (triggerer.tag == "Player")
        {
            triggerer.GetComponent<PlayerMovement>().enabled = false;
            triggerer.GetComponent<Rigidbody>().velocity = Vector2.zero;
        }
    }
}