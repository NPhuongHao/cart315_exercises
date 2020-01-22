using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingg : MonoBehaviour
{
    public float rotate_speed = 1.0f;
    //set variable to public --> variable will be displayed in Component view in Unity Editor

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //this is to create game loops
    void FixedUpdate()
        //FixedUpdate guarantees that the frame will run 60fps, no matter how the render turns out
    {
        if (Input.GetButton("Fire1"))
        {
            this.transform.Rotate(0, rotate_speed, 0);
            //this.transform.Rotate(0,1.0f*Time.deltaTime,0); --> error apparently???
            //convention = when you only write the number, you don't need to define the type of unit. But in any other case, you need to specify (f for floating point, d for double)
            //what is floating point? what is double?
            //Time. deltaTime is essentially a fragment of a second or the time passed since the last frame. So if you move something with it in involved it will move them by time rather than by frame.
        }
    }
}
