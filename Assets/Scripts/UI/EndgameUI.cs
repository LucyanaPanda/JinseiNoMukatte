using TMPro;
using UnityEngine;

public class EndgameUI : MonoBehaviour
{
    [SerializeField] PlayerManager _playerManager;

    [Header("EndgameCanva")]
    [SerializeField] GameObject _victoryText;
    [SerializeField] GameObject _defeatText;

    private void Start()
    {
        if (_playerManager.isFinished)
        {
            _victoryText.SetActive(true);
        }
        else
        {
            _defeatText.SetActive(true);
        }
    }
}
