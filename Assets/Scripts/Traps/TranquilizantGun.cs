using UnityEngine;
using UnityEngine.Rendering;

public class TranquilizantGun : Trap
{
    [SerializeField] Tranquilizant _prefab;
    [SerializeField] private float _maxTimer;
    [SerializeField] private float _timer;
    [SerializeField] private Transform _transform;

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= _maxTimer)
        {
            _timer -= _maxTimer;
            ShootTranquilizant();
        }
    }

    private void ShootTranquilizant()
    {
        if (_prefab != null)
        {
            Tranquilizant bullet = Instantiate(_prefab, _transform.position, Quaternion.identity);
        }
    }
}
