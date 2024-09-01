using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoverForEnemy : MonoBehaviour
{
    private float _speed = 5f;

    private void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }
}
