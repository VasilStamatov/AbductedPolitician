using UnityEngine;
using System.Collections;

public class PlayerCollisions : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Obstacle" || col.collider.tag == "MovingObstacle")
        {
            Destroy(gameObject);
            Debug.Log("LOL YOU DIED");
            Application.LoadLevel(Application.loadedLevel);
        }

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "WinningTrigger")
        {
            Debug.Log("You Won!");
        }
        else if (col.tag == "Obstacle" || col.tag == "MovingObstacle")
        {
            Destroy(gameObject);
            Debug.Log("LOL YOU DIED");
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
