using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] public GameObject _gameOver;

    private void Awake()
    {
        if(instance == null)
            instance = this;


        Time.timeScale = 1f;

    }



    public void GameOver()
    {
        _gameOver.SetActive(true);
        Time.timeScale = 0f;
        AudioManager.instance.Death();




    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
