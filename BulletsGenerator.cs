using UnityEngine;

public class BulletGenerator : ObjectPool<Bullets>
{
    [SerializeField] protected Bullets _bulletPrefab; 
    private float _deactivateTime = 3f;

    private void Start()
    {
        Create(_bulletPrefab); 
    }

    protected void SpawnBullet()
    {
        if (TryGetObject(out Bullets bullet))
        {
            SetObject(bullet);
            StartCoroutine(UpdateDeactivateTimer(bullet, _deactivateTime));
        }
    }
}