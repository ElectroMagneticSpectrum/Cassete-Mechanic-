using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag_object : MonoBehaviour
{
    public  float Start_PositionX;
    public  float Start_PositionY;
    public  bool held = false;


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
