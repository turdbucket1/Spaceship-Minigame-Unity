using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{

 float randomMoveSpeed;
 float randomRotationSpeedX;
 float randomRotationSpeedY;
 float randomRotationSpeedZ;
 float randomPositionV;
 float randomPositionH;
 [SerializeField] Vector3 RotationAxis;
 [SerializeField] private aeronef aeronef;
    

    
    


    // Start is called before the first frame update
    void Start()
    {

        

        randomMoveSpeed = UnityEngine.Random.Range(3.0f, 8.0f);

        randomRotationSpeedX = UnityEngine.Random.Range(10, 60.0f);
       
        randomRotationSpeedY = UnityEngine.Random.Range(10, 60.0f);

        randomRotationSpeedZ = UnityEngine.Random.Range(10, 60.0f);

        randomPositionV = UnityEngine.Random.Range(-6.15f, 6.15f);
        
        randomPositionH = UnityEngine.Random.Range(15.5f, 18.5f);



        transform.position = new Vector3(20.0f, 0.5f, randomPositionV);

       transform.rotation = new Quaternion(randomRotationSpeedX, randomRotationSpeedY, randomRotationSpeedZ, 0 );

       


    }


 

    // Update is called once per frame
    void Update()
    {

        

      


        if (transform.position.x <= -16.0f)

            {
            randomMoveSpeed = UnityEngine.Random.Range(3.0f, 8.0f);
           
            randomPositionV = UnityEngine.Random.Range(-6.15f, 6.15f);

            randomPositionH = UnityEngine.Random.Range(15.5f, 18.5f);

            transform.position = new Vector3(randomPositionH, 0.5f, randomPositionV);


            randomRotationSpeedX = UnityEngine.Random.Range(10, 90.0f);

            randomRotationSpeedY = UnityEngine.Random.Range(10, 90.0f);

            randomRotationSpeedZ = UnityEngine.Random.Range(10, 90.0f);

            
        }

        

        float moveX = randomMoveSpeed * Time.deltaTime;

            transform.position -= new Vector3(moveX, 0, 0);


            float rotationAngleX = randomRotationSpeedX * Time.deltaTime;

            transform.Rotate(RotationAxis, rotationAngleX);


            float rotationAngleY = randomRotationSpeedY * Time.deltaTime;

            transform.Rotate(RotationAxis, rotationAngleY);


            float rotationAngleZ = randomRotationSpeedZ * Time.deltaTime;

            transform.Rotate(RotationAxis, rotationAngleZ);



            if (aeronef.explode == true)
                {
                    transform.position = new Vector3(22.0f, 0.5f, randomPositionV);
                

              }




    }
}








