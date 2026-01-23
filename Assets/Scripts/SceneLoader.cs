using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void StartGame() => SceneManager.LoadScene("InGame");

    public void SettingsGame() => SceneManager.LoadScene("Settings"); // NOT COMPLETED

    public void QuitGame() => Application.Quit();
}
