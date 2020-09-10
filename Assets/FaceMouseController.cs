using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceMouseController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            //deactive left arm script
            GameObject.Find("Right").GetComponent<FaceMouse>().enabled = true;
            GameObject.Find("Left").GetComponent<FaceMouse1>().enabled = false;
           
        }
        if (Input.GetKey(KeyCode.A))
        {
            //deactive right arm script
            GameObject.Find("Left").GetComponent<FaceMouse1>().enabled = true;
            GameObject.Find("Right").GetComponent<FaceMouse>().enabled = false;
        
        }
        else
        {

        }
       
    }
}
