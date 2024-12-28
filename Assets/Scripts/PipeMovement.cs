using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] GameObject _pipe;
    [SerializeField] float _moveSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * _moveSpeed * Time.deltaTime;
    }
}
