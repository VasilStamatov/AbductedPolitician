using UnityEngine;
using System.Collections;

public class MovingPlatforms : MonoBehaviour 
{
    Vector2 startPos;
    public Vector2 endPos;
    bool isReady;

    void Start()
    {
        isReady = true;
        startPos = transform.position;
    }

	void Update ()
    {
        if (isReady == true)
        {
            StartCoroutine(Move());            
        }
	}

    public IEnumerator Move()
    {
        isReady = false;
        float progress = 0.0f;
        float rate = 1f / 4f;
        while (progress <= 1.0f)
        {
            transform.position = Vector2.Lerp(startPos, endPos, progress);
            progress += Time.deltaTime * rate;
            yield return null;
        }

        progress = 0.0f;
        while (progress <= 1.0f)
        {
            transform.position = Vector2.Lerp(endPos, startPos, progress);
            progress += Time.deltaTime * rate;
            yield return null;
        }
        isReady = true;
    }
}
