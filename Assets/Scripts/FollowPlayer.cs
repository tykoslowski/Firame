using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // stores player
    public Vector3 offset; // stores three floats

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;  // adds the offset we want to the player position 
                                                        // (just player.position gives us first person view)
    }
}
