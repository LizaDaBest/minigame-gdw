using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject sphere;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(sphere);
    }
}
