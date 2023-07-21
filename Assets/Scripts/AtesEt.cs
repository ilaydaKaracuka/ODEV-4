using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtesEt : MonoBehaviour
{
    
    
   
    void Update()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward*1000 , Color.green);
        if (Input.GetMouseButton(0))
        {
            if(Physics.Raycast(transform.position,transform.forward,out hit,Mathf.Infinity)) //true ise temas ettiyse
            {
                
                if (hit.collider.gameObject.tag=="enemy")
                {
                    
                    Destroy(hit.collider.gameObject);
                    print("yok edildi");
                }
            }
        }
        
    }

  
}
