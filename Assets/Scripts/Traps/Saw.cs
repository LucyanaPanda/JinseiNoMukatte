using System.Resources;
using UnityEngine;

public class Saw : Trap
{
    [SerializeField] private bool _isMoving;
    [SerializeField] private bool _isMovingRight;
    [SerializeField] private float _speed;
    [SerializeField] private float _timer;
    [SerializeField] private float _maxTimer;
    [SerializeField] private Vector3 _dir;

    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _isMovingRight = true;
    }

    private void Update()
    {
        if (_isMoving)
            MoveSaw();
    }

    private void MoveSaw()
    {
        _timer += Time.deltaTime;
        if (_timer <= _maxTimer)
        {
           if(_isMovingRight)
               _transform.position += _dir * _speed * Time.deltaTime;
           else
               _transform.position += -_dir * _speed * Time.deltaTime;
        }
        else
        {
           _timer -= _maxTimer;
           if (_isMovingRight)
              _isMovingRight = false;
           else
              _isMovingRight = true;
        }
    }
}
