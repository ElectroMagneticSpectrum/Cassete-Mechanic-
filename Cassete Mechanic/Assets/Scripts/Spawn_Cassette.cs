using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Cassette : MonoBehaviour
{
    public GameObject Cassette;

    public GameObject Spawn_Point;

    public Vector3 Spawn_Point_Location;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Spawn_Point_Location = Spawn_Point.transform.position; 
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(Cassette,Spawn_Point_Location, Quaternion.identity);


        }
        
    }

  
}
