using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject sphere;
    public GameObject cube;
    public GameObject projectilePrefab;
    public Rigidbody rb;
	void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        {
            rb.velocity = (Vector3.MoveTowards(transform.position, cube.transform.position, (float).005));
		   //transform.position = Vector3.MoveTowards(transform.position, cube.transform.position, (float).005);
		}


        // Collide with cube

        {

		}

        //Collide with projectile

        {

        }

    }
}
