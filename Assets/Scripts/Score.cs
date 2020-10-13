using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0"); // Change position to string so it can successfully be shown as scoreText
                                                          // "0" is for 0 precision so we just have a whole number display
    }
}