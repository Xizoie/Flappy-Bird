using System;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _yPos = 0.6f;
    [SerializeField] GameObject _pipe;

    private float _time;

    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        if (_time > _maxTime)
        {
            _time = 0;
            SpawnPipe();
        }
        _time += Time.deltaTime / 2;



    }
    private void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, UnityEngine.Random.Range(-_yPos, _yPos));
        GameObject pipe = Instantiate(_pipe, spawnPos, Quaternion.identity);
        Destroy(pipe, 20f);
    }

}
