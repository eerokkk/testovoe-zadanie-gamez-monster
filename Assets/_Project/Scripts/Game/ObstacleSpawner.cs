using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject obstacle;
    [SerializeField]
    private GameObject obstacleClone;

    private const float maxHeight = 3f;
    private const float spawnDisctanceX = 15f;
    private const float moveDisctanceObstacle = 30f;

    private void Start()
    {
        obstacleClone = Instantiate(obstacle, new Vector3(spawnDisctanceX, Random.Range(-maxHeight, maxHeight), 1f), Quaternion.identity);

        StartCoroutine(MoveObstacle());
    }

    IEnumerator MoveObstacle()
    {
        for (; ; )
        {
            yield return new WaitForSeconds(PlayerPrefs.GetFloat("obstacleSpawnerTimer"));
            print("Teleport courutine run");
            obstacleClone.transform.position = new Vector3(obstacleClone.transform.position.x + moveDisctanceObstacle, Random.Range(-3, 3), 1f);
        }
    }
}
