using TMPro;
using UnityEngine;

public class EnemyLoader : MonoBehaviour
{
    public GameObject firstEnemyPrefab;
    public Transform canvasTransform;

    public TMP_Text enemyInfo;

    void Start()
    {
        Instantiate(firstEnemyPrefab, canvasTransform);
        enemyInfo.text = firstEnemyPrefab.GetComponentInChildren<TMP_Text>().text;
    }
}
