using UnityEngine;
using System.Collections;

public class ObstacleLogic : MonoBehaviour 
{
    Vector2 startPos;
    Vector2 endPos;

    ObstacleCollision triggerActivity;
	// Use this for initialization
	void Start () 
    {
        triggerActivity = gameObject.GetComponentInChildren<ObstacleCollision>();
        startPos = transform.position;
        endPos = Vector2.down;
	}

    public IEnumerator FallDown()
    {
        float progress = 0.0f;
        while (progress <= 1.0f)
        {
            transform.position = Vector2.LerpUnclamped(startPos, endPos, progress);
            progress += Time.deltaTime;

            yield return null;
        }
        progress = 0.0f;

        while (progress <= 1.0f)
        {
            transform.position = Vector2.LerpUnclamped(endPos, startPos, progress);
            progress += Time.deltaTime;

            yield return null;
        }
        triggerActivity.SetTrapActivity(false);
    }
}
