using System.Collections;
using UnityEngine;

public class BulletGeneratorForEnemy : BulletGenerator
{
    private float _spawnInterval = 2;

    private void Start()
    {
        Create(_bulletPrefab);
        StartCoroutine(SpawnBulletCoroutine());
    }

    private IEnumerator SpawnBulletCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(_spawnInterval);
            SpawnBullet();
        }
    }
}
