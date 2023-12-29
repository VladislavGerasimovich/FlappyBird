using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private ShootPoint _shootPoint;
    [SerializeField] private Bullet _bullet;

    private WaitForSeconds _delay;

    private void Awake()
    {
        _delay = new WaitForSeconds(2);
    }

    private void Start()
    {
        StartCoroutine(Fire());
    }

    private IEnumerator Fire()
    {
        while (enabled)
        {
            yield return _delay;

            CreateBullet();
        }
    }

    private void CreateBullet()
    {
        Instantiate(_bullet, _shootPoint.transform.position, _shootPoint.transform.rotation);
    }
}
