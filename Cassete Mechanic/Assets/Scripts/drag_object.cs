using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag_object : MonoBehaviour
{
    public  float Start_PositionX;
    public  float Start_PositionY;
    public  bool held = false;

    public Vector3 WhenDragOut;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( held == true)
        {
        Vector3 Mouse_Position;
        Mouse_Position = Input.mousePosition;
        Mouse_Position = Camera.main.ScreenToWorldPoint(Mouse_Position);


        this.gameObject.transform.localPosition = new Vector3(Mouse_Position.x - Start_PositionX,Mouse_Position.y - Start_PositionY,0 );

        WhenDragOut.x = 2f;
        WhenDragOut.y = -4f;
        WhenDragOut.z = 0f;
        





        if(transform.position.x >= 10  ){
              transform.position = WhenDragOut ;

        }

        if(transform.position.x <= -5.74f  ){
              transform.position = WhenDragOut ;

        }

        if(transform.position.y  <= -5.54f  ){
              transform.position = WhenDragOut ;

        }


        }
    }

    private void OnMouseDown()
    {
       if(Input.GetMouseButtonDown(0))
       {
        Vector3 Mouse_Position;
        Mouse_Position = Input.mousePosition;
        Mouse_Position = Camera.main.ScreenToWorldPoint(Mouse_Position);

       Start_PositionX = Mouse_Position.x - this.transform.localPosition.x;
       Start_PositionY = Mouse_Position.y - this.transform.localPosition.y;

        held = true;
        }


    }
    
    private void  OnMouseUp()
    {

        held = false;


    }

}
