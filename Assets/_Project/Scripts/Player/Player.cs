using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Game game;
    [SerializeField]
    private Rigidbody2D playerRigidbody2D;

    private void Start()
    {
        game = GameObject.FindGameObjectWithTag("GameController").GetComponent<Game>();
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Lose()
    {
        game.OnPlayerLose();
        playerRigidbody2D.velocity = Vector2.zero;
        this.gameObject.SetActive(false);
    }
}
