using UnityEngine;
using System.Collections;

public class TrapTriggerStatic : MonoBehaviour 
{
    private Vector2 startingPos;

	// Use this for initialization
	void Awake () 
    {
        startingPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.position = startingPos;
	}
}
