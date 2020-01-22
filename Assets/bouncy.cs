using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//when player enters this zone, player bounces uppp

public class bouncy : MonoBehaviour
{
    public float bounce_level = 500f * Time.deltaTime;
    
    public GameObject the_other_object;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        other.GetComponent<Rigidbody>().AddForce(0, bounce_level, 0);
        //normal for bounce
        //add *Time.deltaTime for floating effect
    }

    private void OnTriggerEnter(Collider other)
    {
        //other.GetComponent<AudioSource>().Play();
        if (other.gameObject == the_other_object)
        {
            other.GetComponent<AudioSource>().Play();
        }
    }
}
