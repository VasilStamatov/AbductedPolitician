using UnityEngine;
using System.Collections;

/// <summary>
/// Checks if the player is on the ground or in the air
/// </summary>
public class CheckLanding : MonoBehaviour 
{
    private PlayerMovement player;
	// Use this for initialization
	void Start ()
    {
        player = gameObject.GetComponentInParent<PlayerMovement>();
	}
	
	void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag != "TrapTrigger")
        {
            transform.parent = player.transform;
            player.isJumping = false;
            player.setJump(0);
        }
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag != "TrapTrigger")
        {
            player.isJumping = false;
            player.setJump(0);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag != "TrapTrigger")
        {
            transform.parent = player.transform;
            player.isJumping = true;
        }
    }
}
