using UnityEngine;
using TMPro;
public class ScoreScript : MonoBehaviour
{

    public static ScoreScript instance;

    [SerializeField] private TextMeshProUGUI _currentScore;
    [SerializeField] private TextMeshProUGUI _maxScore;

    private int _score;
    void Start()
    {
        _currentScore.text = _score.ToString();
        _maxScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();//Only for small data
        UpdateHighScore();
    }

    void Update()
    {
        
    }

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", _score);
            _maxScore.text = _score.ToString() ;
        }
    }

    public void UpdateScore()
    {
        _score++;
        _currentScore.text = _score.ToString();
        UpdateHighScore();

    }
}
