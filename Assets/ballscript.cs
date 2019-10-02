using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballscript : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector2 (8f, 8f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x >= 11.14f)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
        }

        if (this.transform.position.x >= -11.14f)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
        }
        


    }
}
