using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float speed = 1; 
    //public int Hp = 0;


    // Update is called once per frame
    void Update()
    {
        //Storing the current poition of the object;
        Vector3 temp = this.transform.position;

        // Alternative: temp.x = temp.x + speed
        // Add speed to current x value of temp
        temp.x += speed * Time.deltaTime;

        //Assign temp as the new position of the object.
        //Teleporting the object a very small amount bery quickly.

        this.transform.position = temp;
    }
}
