using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BirdMover))]
public class Bird : MonoBehaviour
{
    public event UnityAction GameOver;
    public event UnityAction<int> ScoreChanged;
    private BirdMover _mover;

    [SerializeField] private int _score;

    private void Start()
    {
        _mover = GetComponent<BirdMover>();
    }

    public void IncreaseScore()
    {
        _score++;
        ScoreChanged?.Invoke(_score);
    }

    public void ResetPlayer()
    {
        _score = 0;
        ScoreChanged?.Invoke(_score);
        _mover.ResetBird();
    }

    public void Die()
    {
        GameOver?.Invoke();
    }
}
