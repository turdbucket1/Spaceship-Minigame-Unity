using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    float randomRotationSpeedX;
    float randomRotationSpeedY;
    float randomRotationSpeedZ;
    float randomPositionV;
    float randomPositionH;
 
    [SerializeField] public aeronef aeronef;
    [SerializeField] Vector3 RotationAxis;



    void Start()
    {
        aeronef.bombActive = false;


        randomRotationSpeedX = UnityEngine.Random.Range(10, 60.0f);

        randomRotationSpeedY = UnityEngine.Random.Range(10, 60.0f);

        randomRotationSpeedZ = UnityEngine.Random.Range(10, 60.0f);

        randomPositionV = UnityEngine.Random.Range(-6.15f, 6.15f);

        randomPositionH = UnityEngine.Random.Range(16.0f, 160.0f);


        transform.position = new Vector3(randomPositionH, 0.5f, randomPositionV); 
        
        
       
    }


    void Update()
    {
        if (transform.position.x <= -15.75f)

        {
            randomPositionV = UnityEngine.Random.Range(-6.15f, 6.15f);

            randomPositionH = UnityEngine.Random.Range(16.0f, 160.0f);

            transform.position = new Vector3(randomPositionH, 0.5f, randomPositionV);
        }

        float moveX = 6 * Time.deltaTime;

        float rotationAngleX = randomRotationSpeedX * Time.deltaTime;

        transform.Rotate(RotationAxis, rotationAngleX);


        float rotationAngleY = randomRotationSpeedY * Time.deltaTime;

        transform.Rotate(RotationAxis, rotationAngleY);


        float rotationAngleZ = randomRotationSpeedZ * Time.deltaTime;

        transform.Rotate(RotationAxis, rotationAngleZ);

        transform.position -= new Vector3(moveX, 0, 0);

       if (aeronef.bombActive == true)
        
        {
            transform.position = new Vector3(randomPositionH, 0.5f, randomPositionV);
        }

    }

    

}