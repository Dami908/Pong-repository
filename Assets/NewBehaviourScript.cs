using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject Bat1;
    public GameObject Bat2;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        Bat1 = GameObject.Find("Bat_1");
        Bat2 = GameObject.Find("Bat_2");
        rb.velocity = new Vector2(10f, 10f);

        



    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(this.transform.position.x) >= 13f)
        {
            this.transform.position=new Vector3(0f,0f,0f);
            StartCoroutine(Pause());
        }

        


        IEnumerator Pause()
        {
            int directionX = Random.Range(-1, 2);
            int directionY = Random.Range(-1, 2);
            if (directionX == 0)
            {
                directionX = 1;
            }




            rb.velocity = new Vector2(0f, 0f);
            yield return new WaitForSeconds(2);
            rb.velocity = new Vector2(12f*directionX, 10f*directionY);
        }


        void OnCollisionEnter2D(Collision2D hit)
        {
            if (hit.gameObject.name == "Bat_1")
            {
                if (Bat1.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
                {
                    rb.velocity = new Vector2(10f , 10f);
                }
                else if (Bat1.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
                {
                    rb.velocity = new Vector2(10f , -10f);
                }
                else
                {
                    rb.velocity = new Vector2(12f ,0f);
                }
                if (hit.gameObject.name == "Bat_2")
                {
                    if (Bat2.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
                    {
                        rb.velocity = new Vector2(-10f, 10f);
                    }
                    else if (Bat2.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
                    {
                        rb.velocity = new Vector2(-10f, -10f);
                    }
                    else
                    {
                        rb.velocity = new Vector2(-10f, 0f);
                    }
                }
            }
           
        }
            
        

               


    }
}
