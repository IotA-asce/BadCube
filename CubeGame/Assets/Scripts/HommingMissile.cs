using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class HommingMissile : MonoBehaviour
{

    public float speed = 50f;
    public float rotateSpeed = 2200f;
    public Transform target;
    public float timer;

    public int RangeX = 200;
    public int RangeY = 70;
    public string objectTag = "Player";


    private Rigidbody2D rb2d;
    private Vector2 pos;
    private int x, y, z;
    //private Tra

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        x = Random.Range(RangeX, RangeX - 130);
        y = Random.Range(-70, 70);
        pos = new Vector2(x, y);
        
        transform.position = pos;

        try{
            target = GameObject.FindGameObjectWithTag(objectTag).transform;
        }catch(MissingReferenceException e)
        {
            Debug.Log("Destroyed");
        }
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer = Time.timeSinceLevelLoad;
        Vector2 direction = (Vector2)target.position - rb2d.position;

        direction.Normalize();
        float rotateAmount = Vector3.Cross(direction, transform.up).z;

        rb2d.angularVelocity = -rotateAmount * rotateSpeed;
        rb2d.velocity = transform.up * speed;

        /*
        int factor = countFrames % 300;
        if (countFrames == 1000000)
        {
            countFrames = 0;
        }
        if (factor == 0)
        {
            speed += force;
            rotateSpeed += rotateForce;
            rotateForce += 200;
        }
        countFrames++;
        Debug.Log(countFrames);
        */
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == objectTag)
        {
            x = Random.Range(RangeX, RangeX - 130);
            y = Random.Range(-70, 70);
            pos = new Vector2(x, y);

            transform.position = pos;
        }
        int factor = (int)(timer % 5);

        if (factor == 0)
        {
            x = Random.Range(RangeX, RangeX - 130);
            y = Random.Range(-RangeY, RangeY);
            pos = new Vector2(x, y);

            transform.position = pos;
        }
    }
    
    /*void OnTriggerEnter(collider : Collider)
    {
        if (collider.tag == "Player")
        {
            Destroy(gameObject);   
        }
    }*/
}
