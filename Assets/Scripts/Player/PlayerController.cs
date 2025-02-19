using System.Data;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _dir; 
    [SerializeField] private Transform _transform;
    [SerializeField] private Transform _transformBody;

    [Header("LookAt")]
    [SerializeField] private Vector3 _lookRight;
    [SerializeField] private Vector3 _lookLeft;

    [Header("Jump")]
    [SerializeField] private float _jumpForce;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _playerHeight;
    [SerializeField] private float _offset;

    [Header("LayerMask")]
    [SerializeField] private LayerMask _floorLayer;

    private Vector2 _jumpForceVector;


    private void Awake()
    {
        _jumpForceVector = new Vector2(0, _jumpForce);
    }

    private void Update()
    {
        MovePlayer();
    }

    public void OnLeftRightMovement(InputAction.CallbackContext context)
    {
        _dir = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        RaycastHit2D hitInfos = Physics2D.Raycast(_transform.position, Vector2.down, (_playerHeight/2) + _offset , _floorLayer);
        if (hitInfos)
        {
            if (context.started)
            {
                _rb.AddForce(_jumpForceVector);
            }
        }
    }
    
    private void MovePlayer()
    {
        _transform.position += _dir * _speed * Time.deltaTime;

        if (_dir.x < 0)
        {
            _transformBody.localScale = _lookLeft;
        } 
        else if (_dir.x > 0) 
        {
            _transformBody.localScale = _lookRight;
        }
    }
}
