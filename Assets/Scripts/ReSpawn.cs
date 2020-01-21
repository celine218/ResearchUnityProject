using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]Transform origin;

    public GameObject square;
    public GameObject square2;
    public GameObject square3;
    public GameObject square4;
    float randX;
    float randY;
    Vector2 whereToSpawn;

    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.name == "redsquare")
        {
            col.transform.position = origin.position;
            randX = Random.Range(-8.4f, 8.4f);
            randY = Random.Range(-5f, 5f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(square, whereToSpawn, Quaternion.identity);
            Destroy(gameObject);
        }
        if (col.gameObject.name == "redsquare")
        {
            randX = Random.Range(-8.4f, 8.4f);
            randY = Random.Range(-5f, 5f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(square2, whereToSpawn, Quaternion.identity);
        }
        if (col.gameObject.name == "redsquare")
        {
            randX = Random.Range(-8.4f, 8.4f);
            randY = Random.Range(-5f, 5f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(square3, whereToSpawn, Quaternion.identity);
        }
        if (col.gameObject.name == "redsquare")
        {
            randX = Random.Range(-8.4f, 8.4f);
            randY = Random.Range(-5f, 5f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(square4, whereToSpawn, Quaternion.identity);
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
