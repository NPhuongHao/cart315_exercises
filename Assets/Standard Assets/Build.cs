using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{
    //create a camera object (and you need to assign it later in the unity viewport)
    public GameObject thecamera;
    //this is the object that you will be creating with the raycast
    public GameObject create;

    //set building speed
    private int count = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        //current speed = 60fps
        //slow speed to 1/2
        count = count + 1;
        if (count > 2)
        {
            count = 0;
        }
        //ray cast when right mouse button is down
        if (Input.GetMouseButton(1) && count == 0)
            //check if right mouse button (parameter 1) is down
        {
            //create an invisible ray to detect what player is looking at, then create an object on that position

            //step 1: create the ray output
            RaycastHit hit;
                //this hit will be passed as the output parameter

            //step 2: create the ray coming from the camera position
            Ray ray = thecamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition); //thecamera refers to line 7-8 //get camera component gives a special function that makes it easier to make a ray
                                                                                              //ScreenPointToRay(Input.mousePosition): wherever you mouse points, your ray will go there

            //step 3: CAST IT
            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) //this is Raycast() formula 6 //Mathf.Infinity = create foreverrrr
            {
                //create the object where the ray hits
                GameObject.Instantiate(create, hit.point, Quaternion.identity); //'create' parameter refers to line 9-10 //Quaternion.identity --> no rotation??? https://docs.unity3d.com/ScriptReference/Quaternion.html
            };
                
        }
    }
}
