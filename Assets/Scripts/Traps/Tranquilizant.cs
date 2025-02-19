using UnityEngine;
using UnityEngine.Tilemaps;

public class Tranquilizant : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private Transform _transform;
    [SerializeField] private float _speed;

    private void Update()
    {
        _transform.position += -_transform.right * _speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerManager player = collision.gameObject.GetComponent<PlayerManager>();
        if (player != null)
        {
            player.ReturnToSpawnPoint();
            Destroy(this.gameObject);
        }
    }
}
