using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class showLives : MonoBehaviour
{
    public int maxLives = 3;

    [SerializeField] private TMP_Text textLives;
    [SerializeField] private TMP_Text textGameOver;


    // Start is called before the first frame update
    void Start()
    {
        textLives.text = ("Lives: " + maxLives).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "asteroid_debris")
        {
            maxLives = maxLives - 1;

            textLives.text = "Lives: " + maxLives.ToString();

            
        }
             if (maxLives == 1)
             {
                textLives.text = (" 1 life remaining ").ToString();

             }
       
        if (maxLives <= 0)
        {
            Destroy(gameObject);
            textLives.text = ("0 lives left").ToString();
            textGameOver.text = ("You died. DISTANCE TRAVELLED: " + ((float)Time.realtimeSinceStartup).ToString() + " km");

        }
    }
}
