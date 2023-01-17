using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIDataRefresh : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI timeCount;
    [SerializeField]
    private TextMeshProUGUI totalAttemptCount;
    [SerializeField]
    private TMP_Dropdown dropdown;
    [SerializeField]
    private Game game;

    private void Start()
    {
        game = GetComponent<Game>();
    }

    public void RefreshTimeCount()
    {
        timeCount.text = $"Продолжительность последней попытки - {Time.timeSinceLevelLoad} c";
    }

    public void RefreshTotalAttemptCount()
    {
        totalAttemptCount.text = $"Всего попыток - {PlayerPrefs.GetInt("totalAttempt")}";
    }

    public void SelectGameDifficulty()
    {
        switch (dropdown.value)
        {
            case 0:
                print("Easy difficulty");
                PlayerPrefs.SetString("gameDifficulty", "Easy");
                PlayerPrefs.SetFloat("obstacleSpawnerTimer", 10);
                break;
            case 1:
                print("Normal difficulty");
                PlayerPrefs.SetString("gameDifficulty", "Normal");
                PlayerPrefs.SetFloat("obstacleSpawnerTimer", 7);
                break;
            case 2:
                print("Hard difficulty");
                PlayerPrefs.SetString("gameDifficulty", "Hard");
                PlayerPrefs.SetFloat("obstacleSpawnerTimer", 5);
                break;
        }
    }
}
