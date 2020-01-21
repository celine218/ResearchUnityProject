using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    void start()
    {
       
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "redsquare")
        {
            Destroy(col.gameObject);
        }
    }
    // Update is called once per frame

}
