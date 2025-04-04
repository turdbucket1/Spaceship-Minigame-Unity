using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class aeronef : MonoBehaviour
{
    float moveSpeedH;
    float moveSpeedV = 8.0f;
    public bool bombActive;
    public bool explode;
    private GameObject detonator;
    [SerializeField] private bomb bomb;
    [SerializeField] public bombtext bombtext;



    // Start is called before the first frame update
    void Start()
    {
        bombActive = false;

        detonator = GameObject.Find("bomb");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
          {
            moveSpeedH = 9.5f;
          }

        if (Input.GetKey(KeyCode.D))
        {
            moveSpeedH = 9.5f;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveSpeedH = 7.5f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveSpeedH = 7.5f;
        }


        float horizontal = Input.GetAxis("Horizontal") * moveSpeedH * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * moveSpeedV * Time.deltaTime;

        Vector3 movement = new Vector3(horizontal, 0, vertical);
        movement = transform.TransformDirection(movement);

        float positionX = transform.position.x + movement.x;
        float positionZ = transform.position.z + movement.z;

        if (positionX >= -11.5f && positionX <= 11.5f && positionZ >= -6.15f && positionZ <= 6.15f)
        {
            // Changement de la position du joueur
            transform.position = new Vector3(positionX, 0.5f, positionZ);
        }


         
        

            if (Input.GetKey(KeyCode.Space) && (bombActive == true))
            {
                explode = true;
                bombActive = false;
                
            }
            else if (explode)
            {
              explode = false;
            
            }

            if (bombActive == true)
            {
                bombtext.bombText.text = ("Explosive ready").ToString();
            }
            else if (bombActive == false)
            {
                bombtext.bombText.text = (" ").ToString();
            }


        if (Input.GetKey(KeyCode.P))
        {
            
            bombActive = true;

        }

    }

    
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject == detonator)
        {
            bombActive = true;

        }


    }

}
