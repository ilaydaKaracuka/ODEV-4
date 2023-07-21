using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    
   
    public float hiz=1.2f;
    
 
    void Update()
    {
        float x = Random.Range(-10, 5); //Orc'larýn hareketlerini random ata
        float z = Random.Range(-10, 5);

        Vector3 vector = new Vector3(x,0,z);
        Vector3 hizli = vector * hiz * Time.deltaTime;
       transform.position += hizli;

    }
}
