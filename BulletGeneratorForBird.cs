using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGeneratorForBird : BulletGenerator
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            SpawnBullet();
    }
}
