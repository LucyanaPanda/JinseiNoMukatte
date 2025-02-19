using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    [Header("Attack")]
    [SerializeField] private int _damage;
    [SerializeField] private float _attackTimer;
    [SerializeField] private float _attackMaxTimer;
    [SerializeField] private float _attackRange;
    [SerializeField] private Transform _attackTransform;

    [Header("LayerMask")]
    [SerializeField] private LayerMask _attackLayer;

    private RaycastHit2D[] hits;

    private void Update()
    {
        Attack();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if (_attackTimer >= _attackMaxTimer)
        {
            _attackTimer -= _attackMaxTimer;
            hits = Physics2D.CircleCastAll(_attackTransform.position, _attackRange, transform.forward, 0f, _attackLayer);

            for (int i = 0; i < hits.Length; i++)
            {
                IDamageable iDamageable = hits[i].collider.gameObject.GetComponent<IDamageable>();

                if (iDamageable != null)
                {
                    iDamageable.TakeDamage(_damage);
                }
            }
        }
    }
    private void Attack()
    {
        if (_attackTimer <= _attackMaxTimer)
        {
            _attackTimer += Time.deltaTime;
        }
    }
}
