using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    private GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("aeronef");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject == player)
        {
            Destroy(gameObject);
        }

        
    }
}
