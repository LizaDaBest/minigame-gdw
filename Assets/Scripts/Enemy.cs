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
        rb.AddForce(cube.transform.position - transform.position, ForceMode.Impulse);
        StartCoroutine(enemyPath());
        
    }

    // Update is called once per frame
    void Update()
    {

        {
            // rb.addForce = (Vector3.MoveTowards(transform.position, cube.transform.position, (float).005));
		   // transform.position = Vector3.MoveTowards(transform.position, cube.transform.position, (float).005);
          // rb.AddForce(cube.transform.position - transform.position, ForceMode.Acceleration);
		}


        // Collide with cube

        {

		}

    }

    IEnumerator enemyPath()
    {
        yield return new WaitForSeconds(Random.Range(0,4));
        rb.AddForce((cube.transform.position - transform.position) / 2, ForceMode.Impulse);
        StartCoroutine(enemyPath());
    }

    private void OnCollisionEnter(Collision other)
    {
    if (other.gameObject.CompareTag("Projectile"))
        {
            Destroy(gameObject);
        }
    }
}


