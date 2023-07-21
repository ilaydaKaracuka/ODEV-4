using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankHareket : MonoBehaviour
{
    public float speed = 1.2f;
   
    void Update()
    {
        Vector3 vect = new Vector3(Input.GetAxis("Horizontal"),0.0f,Input.GetAxis("Vertical")); //x ve z de hareket etsin
        Vector3 tank = vect * speed * Time.deltaTime;
        transform.Translate(tank);

    }
}
