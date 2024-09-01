using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BirdMover))]
public class Bird : MonoBehaviour, IResetble
{
    private BirdMover _birdMover;

    public event UnityAction GameOver;
    public event UnityAction<int> ScoreChecnged;

    private int _score = 0;

    private void Awake()
    {
        _birdMover = GetComponent<BirdMover>();
    }

    public void Add()
    {
        _score++;
        ScoreChecnged?.Invoke(_score);
    }

    public void Reset()
    {
        _score = 0;
        _birdMover.Reset();
        ScoreChecnged?.Invoke(_score);
    }

    public void Die()
    {
        GameOver?.Invoke();
    }
}
