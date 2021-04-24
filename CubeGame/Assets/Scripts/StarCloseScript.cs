using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCloseScript : MonoBehaviour
{

    public float speed = 5f;
    public Rigidbody2D rb2d;
    
    private Vector2 pos;
    private int x, y, z;

    void Start()
    {
        rb2d = this.GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(-speed, 0);

        x = Random.Range(-180, 200);
        y = Random.Range(-70, 70);
        pos = new Vector3(x, y, 1);

        transform.position = pos;
    }

    
    void Update()
    {
        if (transform.position.x < -180)
        {
            x = Random.Range(-180, 200);
            y = Random.Range(-70, 70);
            pos = new Vector3(x, y, 1);

            transform.position = pos;
        }
    }
}
