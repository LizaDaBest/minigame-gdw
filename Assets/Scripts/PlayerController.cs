using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public GameObject projectilePrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * hInput);
        float vInput = Input.GetAxisRaw("Vertical");
            transform.Translate(Vector3.up * speed * Time.deltaTime * vInput);

        // Fire projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);

        }

        // Perhaps try to fix the fast diagonal movement
    }
}
