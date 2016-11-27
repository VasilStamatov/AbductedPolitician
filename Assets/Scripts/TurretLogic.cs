using UnityEngine;
using System.Collections;

public class TurretLogic : MonoBehaviour
{
    public GameObject projectile;

    public float shootingCooldown = 3f;

    void Start()
    {
    }

    void Update()
    {
        if (shootingCooldown <= 0.0f)
        {
            GameObject clone = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
            clone.transform.Translate(Vector3.zero);
            shootingCooldown = 3.0f;
        }
        else
        {
            shootingCooldown -= Time.deltaTime;
        }
    }
}
