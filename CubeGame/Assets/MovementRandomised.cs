using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRandomised : MonoBehaviour
{
    public int limitX = 15;
    public int limitY = 12;
    private Vector2 pos;
    private int x, y, z;

    public float timer;
    public int count = 0;

    void Start()
    {
        
          
            timer = 0;
            x = Random.Range(-limitX, limitX);
            y = Random.Range(-limitY, limitY);
            pos = new Vector3(x, y, 1);
            count = 0;

            transform.position = pos;
        
    }

    void FixedUpdate()
    {
        timer = Time.timeSinceLevelLoad;
        count++;

        int factor = count % 120;
        if (factor == 0)
        {
            PositionUpdate();
        }
    }

    public void PositionUpdate()
    {
        x = Random.Range(-limitX, limitX);
        y = Random.Range(-limitY, limitY);
        pos = new Vector3(x, y, 1);
        count = 0;

        transform.position = pos;
    }

}
