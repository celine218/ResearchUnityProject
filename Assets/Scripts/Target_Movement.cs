using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private readonly Rigidbody rb;
    void start()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(0, 0, 1);
    }

    // Update is called once per frame
    
}
