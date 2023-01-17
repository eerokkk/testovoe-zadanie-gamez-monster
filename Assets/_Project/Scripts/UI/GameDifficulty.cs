using TMPro;
using UnityEngine;

public class GameDifficulty : MonoBehaviour
{
    [SerializeField]
    private TMP_Dropdown dropdown;

    private void Awake()
    {
        PlayerPrefs.SetString("gameDifficulty", "Easy");
        PlayerPrefs.SetFloat("obstacleSpawnerTimer", 10);
        dropdown = GetComponent<TMP_Dropdown>();
    }

    public void SetGameDifficulty()
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
