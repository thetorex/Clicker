using UnityEngine;

public class ClickSystem : MonoBehaviour
{
    ScoreManager scoreManager;

    void Start() => scoreManager = GetComponent<ScoreManager>();

    public void Click()
    {
        scoreManager.score++;
        scoreManager.ScoreTextUpdate();
    }
}
