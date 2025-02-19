using UnityEngine;

public class PlayerWallet : MonoBehaviour
{
    [SerializeField] private int _money;

    public void AddMoney(int amout)
    {
        _money += amout;
        Debug.Log("Current money:" + _money.ToString());
    }
}
