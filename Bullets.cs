using UnityEngine;

public class Bullets : MonoBehaviour
{
    private Bird _bird;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out IResetble reset))
        {
            gameObject.SetActive(false);
            reset.Reset();
        }
    }
}
