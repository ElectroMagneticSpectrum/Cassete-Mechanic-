using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewDriver : MonoBehaviour
{
   public Vector3 Pop_up;

   public Vector3 Original;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Pop_up.x = -0.4f;
        Pop_up.y = 0.3f;
        Pop_up.z = 1f;


        Original.x = -0.3085912f;
        Original.y = 0.2633443f;
        Original.z = 1f;

    }


        void OnMouseOver()
    {

        transform.localScale = Pop_up;
        if(Input.GetMouseButtonDown(0))
        {   

            
            
            


        }

   
        
    }

    void OnMouseExit()
    {
        
         transform.localScale = Original;
    }
}

