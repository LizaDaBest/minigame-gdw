using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
	// Start is called before the first frame update
	public GameObject sphere;
	public GameObject cube;
	public GameObject projectilePrefab;
	void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Collide with sphere

        void OnTriggerEnter(Collider other)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
