using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [SerializeField] private AudioClip _audFlip, _audDeath, _audCoin;
    private AudioSource _audioSource;



    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Awake()
    {
        if (instance == null) 
            instance = this;
    }


    public void Flip()
    {
        _audioSource.clip = _audFlip;
        _audioSource.Play();
    }public void Death()
    {
        _audioSource.clip = _audDeath;
        _audioSource.Play();
    }public void Coin()
    {
        _audioSource.clip = _audCoin;
        _audioSource.Play();
    }
        


}
