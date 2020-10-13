using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    bool gameHasEnded = false;

    float restartDelay = 0.3f;
    
    public GameObject completeLevelUI;

    public PlayerMovement playerMovement;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Debug.Log("LEVEL WON");
    }
    
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            //if (Input.GetKey("r")) I want to implement this but I'm not sure how.
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}