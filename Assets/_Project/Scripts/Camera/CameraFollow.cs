using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    private void Start()
    {
        FindPlayer();
    }

    private void Update()
    {
        CameraMove();
    }

    private void CameraMove()
    {
        transform.position = new Vector2(player.position.x, 0);
    }

    private void FindPlayer()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
}
