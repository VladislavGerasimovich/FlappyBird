using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(PlayerMover))]
public class Player : MonoBehaviour
{
    private int _score;
    private PlayerMover _mover;

    public event UnityAction Died;
    public event UnityAction<int> ScoreChanged;


    private void Start()
    {
        _mover = GetComponent<PlayerMover>();
    }

    public void IncreaseScore()
    {
        _score++;
        ScoreChanged?.Invoke(_score);
    }

    public void Reset()
    {
        _score = 0;
        ScoreChanged?.Invoke(_score);
        _mover.ResetMover();
    }

    public void Die()
    {
        Died?.Invoke();
    }
}
