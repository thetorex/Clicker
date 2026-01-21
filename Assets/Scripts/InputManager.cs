using UnityEngine;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // pause game
        {
            Time.timeScale = 0; 
            SceneManager.LoadScene("MainMenu");
        }
    }
}
