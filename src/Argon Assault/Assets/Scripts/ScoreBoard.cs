using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    int _score;
    Text _scoreText;

    [SerializeField] int scorePerHit = 12;

    void Start()
    {
        _scoreText = GetComponent<Text>();
        _scoreText.text = _score.ToString();
    }

    public void ScoreHit()
    {
        _score += scorePerHit;
        _scoreText.text = _score.ToString();
    }
}
