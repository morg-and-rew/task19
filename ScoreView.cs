using TMPro;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
    [SerializeField]private Bird _bird;
    [SerializeField] private TMP_Text _score;

    private void OnEnable()
    {
        _bird.ScoreChecnged += OnScoreChecnged;
    }   
    
    private void OnDisable()
    {
        _bird.ScoreChecnged -= OnScoreChecnged;
    }

    private void OnScoreChecnged(int score)
    {
        _score.text = score.ToString();
    }
}
