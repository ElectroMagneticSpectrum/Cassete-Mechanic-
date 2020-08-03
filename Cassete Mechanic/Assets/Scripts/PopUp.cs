using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
   public Vector3 Pop_up;

   public Vector3 Original;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Pop_up.x = -0.2f;
        Pop_up.y = 0.1653445f;
        Pop_up.z = 1f;


        Original.x = -0.1677183f;
        Original.y = 0.1380489f;
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
