using UnityEngine;

public class EndLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(GameManager.Instance.HasKeyToCastle && other.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            UIManager.Instance.ShowEndLevel();
            GameManager.Instance.GiveStar();
            UIManager.Instance.UpdateStarText();
        }
    }
}