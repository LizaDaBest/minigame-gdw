using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cube;
    public Rigidbody rb;
    public int count = 0;
	void Start()
    {
       // rb = GetComponent<Rigidbody>();
        rb.AddForce((cube.transform.position - transform.position)/2, ForceMode.Impulse);
        StartCoroutine(enemyPath());
        
    }

    // Update is called once per frame
    void Update()
    {

        {
            if (count == 3)
            {
                SceneManager.LoadScene("Movement");
            }
		}


        // Collide with cube

        {

		}

    }

    IEnumerator enemyPath()
    {
        yield return new WaitForSeconds(Random.Range(0,2));
        rb.AddForce((cube.transform.position - transform.position) / 8, ForceMode.Impulse);
        StartCoroutine(enemyPath());
    }

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Movement");
        }

        if (other.tag == "Projectile")
        {
            Destroy(gameObject);
            count += 1;
        }

    }
}


