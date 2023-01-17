using System;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private Move playerMove;
    [SerializeField]
    private GameObject playerClone;
    [SerializeField]
    private UIDataRefresh uiDataRefresh;
    [SerializeField]
    private GameObject losePanel;

    public enum GameState
    {
        Lose,
        Playing
    }

    public enum GameDifficulty
    {
        Easy,
        Normal,
        Hard
    }

    public GameState CurrentGameState { get; private set; }
    public GameDifficulty CurrentGameDifficulty { get; private set; }

    private void Start()
    {
        playerClone = Instantiate(player, new Vector3(transform.position.x, transform.position.y, 1), Quaternion.identity);
        playerMove = playerClone.GetComponent<Move>();

        CurrentGameState = GameState.Playing;

        uiDataRefresh = GetComponent<UIDataRefresh>();
    }

    public void PlayerJump()
    {
        playerMove.PlayerJump();
    }

    public void OnPlayerLose()
    {
        CurrentGameState = GameState.Lose;
        PlayerPrefs.SetInt("totalAttempt", PlayerPrefs.GetInt("totalAttempt") + 1);
        uiDataRefresh.RefreshTimeCount();
        uiDataRefresh.RefreshTotalAttemptCount();
        losePanel.SetActive(true);
        print("Game Over!");
    }
}
