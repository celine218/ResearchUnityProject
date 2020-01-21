using UnityEngine;
using System.Collections;

public class TemplateMovement : MonoBehaviour
{

    [SerializeField]
    private GameObject finalObject;

    private Vector2 mousePos;

    [SerializeField]
    private LayerMask allTilesLayer;
    private Rigidbody rb;
    void start()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(0, 0, 1);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * Time.deltaTime * 5;
        Vector3 vertical = new Vector3(0.0f, Input.GetAxis("Vertical"), 0.0f);
        transform.position = transform.position + vertical * Time.deltaTime * 5;

        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "BlueSquare")
        {
            Debug.Log("Collision");
        }
    }
}
