using UnityEngine;

public class BulletMoverForBird : MonoBehaviour
{
    private Bird _bird;
    private float _speed = 5;

    private void Start()
    {
        _bird = FindObjectOfType<Bird>();
    }

    private void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Enemy enemy))
        {
            _bird.Add();
        }
    }
}