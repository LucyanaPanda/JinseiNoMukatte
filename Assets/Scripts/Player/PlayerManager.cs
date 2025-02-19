using NUnit.Framework;
using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [Header("Sart Position")]
    [SerializeField] Vector2 _initPosition;
    [SerializeField] Transform _playerTransform;
    [SerializeField] private PlayerController _playerController;

    [Header("Endgame")]
    [SerializeField] GameObject _endgameCanva;
    public bool isFinished;

    [Header("Timer")]
    [SerializeField] private float _timerMaxGame;
    public float _timerGame;

    private void Start()
    {
        ReturnToSpawnPoint();
    }

    private void Update()
    {
        FinishedGame();
    }

    public void ReturnToSpawnPoint()
    {
        _playerTransform.position = _initPosition;
    }

    private void FinishedGame()
    {
        _timerGame += Time.deltaTime;
        if (_timerGame >= _timerMaxGame || isFinished == true)
        {
            _endgameCanva.SetActive(true);
            _playerController.enabled = false;
        }
    }
}
