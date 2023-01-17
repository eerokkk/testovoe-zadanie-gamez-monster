using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Move : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D playerRigidbody2D;
    [SerializeField]
    private float playerSpeed;
    [SerializeField]
    private float playerJumpForce;

    private void Awake()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        playerSpeed = 3f;
        playerJumpForce = 250f;
        PlayerMove();
        StartCoroutine(IncreaseVerticalSpeed());
    }

    public void PlayerJump()
    {
        playerRigidbody2D.AddForce(Vector2.up * playerJumpForce);
    }

    private void PlayerMove()
    {
        switch (PlayerPrefs.GetString("gameDifficulty"))
        {
            case "Easy":
                playerRigidbody2D.velocity = Vector2.right * playerSpeed;
                break;
            case "Normal":
                playerRigidbody2D.velocity = Vector2.right * playerSpeed * 1.5f;
                break;
            case "Hard":
                playerRigidbody2D.velocity = Vector2.right * playerSpeed * 2f;
                break;
        }
        //playerRigidbody2D.velocity = Vector2.right * playerSpeed;
    }

    IEnumerator IncreaseVerticalSpeed()
    {
        for(; ; )
        {
            yield return new WaitForSeconds(15);
            playerRigidbody2D.gravityScale += 0.3f;
            playerJumpForce += 20f;
        }
    }
}
