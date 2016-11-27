using UnityEngine;
using System.Collections;

public class ObstacleCollision : MonoBehaviour 
{
    ObstacleLogic fallingObstacle;
    private bool isTrapActive = false;

    public void SetTrapActivity(bool isActive) { isTrapActive = isActive; }

	void Start () 
    {
        fallingObstacle = gameObject.GetComponentInParent<ObstacleLogic>();
	}
    void OnTriggerEnter2D()
    {
        if (isTrapActive == false)
        {
            Debug.Log("Trigger was entered");
            isTrapActive = true;
            fallingObstacle.StartCoroutine(fallingObstacle.FallDown());
        }
    }
}
