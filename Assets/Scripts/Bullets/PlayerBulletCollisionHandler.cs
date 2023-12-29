using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerBulletCollisionHandler : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void Awake()
    {
        _player = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Enemy enemy))
        {
            _player.IncreaseScore();
            enemy.Die();
        }
    }
}
