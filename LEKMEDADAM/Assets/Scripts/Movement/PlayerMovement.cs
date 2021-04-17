using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            Debug.Log("pressed w");
            gameObject.transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown("s"))
        {
            Debug.Log("pressed w");
            gameObject.transform.position += new Vector3(0, -1, 0);
        }
        if (Input.GetKeyDown("a"))
        {
            Debug.Log("pressed w");
            gameObject.transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown("d"))
        {
            Debug.Log("pressed w");
            gameObject.transform.position += new Vector3(1, 0, 0);
        }
    }
}
