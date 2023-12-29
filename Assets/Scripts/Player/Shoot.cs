using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private ShootPoint _shootPoint;
    [SerializeField] private Bullet _bullet;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CreateBullet();
        }
    }

    private void CreateBullet()
    {
        Instantiate(_bullet, _shootPoint.transform.position, _shootPoint.transform.rotation);
    }
}
