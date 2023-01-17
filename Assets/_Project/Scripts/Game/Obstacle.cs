using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Player player))
        {
            print("Collision detected");
            player.Lose();
        }
        else
        {
            return;
        }
    }
}
