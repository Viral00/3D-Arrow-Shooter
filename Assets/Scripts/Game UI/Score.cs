using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int score = 0;
    [SerializeField]private TextMeshProUGUI scoreText;

    private void Start()
    {
        RefreshUI();
    }

    public void IncreaseScore(int increment)
    {
        score += increment;
        RefreshUI();
    }

    private void RefreshUI()
    {
        scoreText.text = "Score : " + score;
    }
}
