using UnityEngine;
using System.Collections;

public class ProjectileMovement : MonoBehaviour
{
    GameObject player;
    Vector2 startPos;
    Vector2 endPos;
    // Use this for initialization
    void Start()
    {

        player = GameObject.Find("Player 1");
        if (player != null)
        {
            startPos = transform.position;
            //endPos = new Vector2(player.transform.position.x, -4.47f);
            endPos = player.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Move());
    }

    public IEnumerator Move()
    {
        float progress = 0.0f;
        float rate = 2f;
        while (progress <= 1.0f)
        {
            if (gameObject != null)
            {
                transform.position = Vector2.Lerp(startPos, endPos, progress);
                progress += Time.deltaTime * rate;
                yield return null;
            }
        }
        Destroy(gameObject);
    }
}
