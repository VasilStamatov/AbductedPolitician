using UnityEngine;
using System.Collections;

public class HoldCharacter : MonoBehaviour
{ 
    void Start ()
    {
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Entered hold char trigger");
        col.collider.transform.parent = gameObject.transform;
    }

    void OnCollisionExit2D(Collision2D col)
    {
        Debug.Log("Exit hold char trigger");
        col.collider.transform.parent = null;
    }
}
