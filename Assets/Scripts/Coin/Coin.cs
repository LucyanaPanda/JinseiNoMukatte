using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _amount;
    private void OnCollisionEnter2D(Collision2D coll)
    {
        PlayerWallet player = coll.gameObject.GetComponent<PlayerWallet>();
        if (player != null)
        {
            player.AddMoney(_amount);
            Destroy(this.gameObject);
        }
    }
}
