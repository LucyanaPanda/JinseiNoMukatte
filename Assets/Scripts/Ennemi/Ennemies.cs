using UnityEngine;

public class Ennemies : MonoBehaviour, IDamageable
{
    [SerializeField] private int _health;
    [SerializeField] private int _maxHealth;
    public int health { get => _health; }

    public void TakeDamage(int _damage)
    {
        _health -= _damage;
        Debug.Log("Took damage");
        OnDeath();
    }

    private void OnDeath()
    {
        if (_health <= 0)
        { 
            Destroy(this.gameObject);
        }
    }
}
