
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;

    public int score;

    void Start() => scoreText = GameObject.Find("ScoreText").GetComponent<TMP_Text>();

    public void ScoreTextUpdate()
    {
        scoreText.text = score.ToString();
    }
}
