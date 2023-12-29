using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerCollisionHandler : MonoBehaviour
{
    [SerializeField] private Player _player;
    
    private void Start()
    {
        _player = GetComponent<Player>();    
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Water water))
        {
            _player.Die();
        }

        if (collision.TryGetComponent(out Enemy enemy))
        {
            _player.Die();
        }

    }
}
