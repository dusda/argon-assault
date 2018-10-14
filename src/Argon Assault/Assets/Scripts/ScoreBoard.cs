using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    int _score;
    Text _scoreText;

    void Start()
    {
        _scoreText = GetComponent<Text>();
        _scoreText.text = _score.ToString();
    }

    public void ScoreHit(int score = 10)
    {
        _score += score;
        _scoreText.text = _score.ToString();
    }
}
