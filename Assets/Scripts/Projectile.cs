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

    private float topBound = 11;

    // Update is called once per frame
    void Update()
    {
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        {
            if (transform.position.y > topBound)
            {
                Destroy(gameObject);
            }
          
        }

    }
}
