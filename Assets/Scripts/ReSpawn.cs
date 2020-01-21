using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Transform origin;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.name == "redsquare")
        {
            col.transform.position = origin.position;
        }
    }

    /*
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "redsquare")
        {
            randX = Random.Range(-8.4f, 8.4f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(square, whereToSpawn, Quaternion.identity);
            Instantiate(square2, whereToSpawn, Quaternion.identity);
            Instantiate(square3, whereToSpawn, Quaternion.identity);
            Instantiate(square4, whereToSpawn, Quaternion.identity);

        }
    }
    */

}
