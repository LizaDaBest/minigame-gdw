using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public GameObject projectilePrefab;
    public GameObject sphere;
    public GameObject cube;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        // Projectiles collide with sphere

        {
            
        }

        // Collide with sphere

        {

        }

    }
}
