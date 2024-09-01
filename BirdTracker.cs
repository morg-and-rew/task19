using UnityEngine;

public class BirdTracker : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private float _xoffset;

    private void Update()
    {
        Vector3 position = transform.position;
        position.x = _bird.transform.position.x + _xoffset;
        transform.position = position;
    }
}
