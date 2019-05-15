using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            Time.timeScale = 0.3f;
            FindObjectOfType<GameManager>().EndGame();
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

}
