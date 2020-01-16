using UnityEngine;
using System.Collections;

public class TemplateMovement : MonoBehaviour
{

    [SerializeField]
    private GameObject finalObject;

    private Vector2 mousePos;

    [SerializeField]
    private LayerMask allTilesLayer;


    // Update is called once per frame
    void Update()
    {
        Vector3 horizontal = new Vector3(Mathf.Round(Input.GetAxis("Horizontal")), 0.0f, 0.0f);
        transform.position = transform.position + horizontal *Time.deltaTime;
        //mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //transform.position = new Vector2(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y));
    }
}
