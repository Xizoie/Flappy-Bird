using UnityEngine;

public class PipeIncreaseScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        { 
            ScoreScript.instance.UpdateScore();
            AudioManager.instance.Coin();
        }
    }
}
