using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    private Vector2 pos;
    private int x, y;
    
    public int rangeX = 200, rangeY = 50;

    void Start()
    {
        x = Random.Range(-rangeX, rangeX);
        y = Random.Range(-rangeY, rangeY);

        pos = new Vector2(x, y);

        transform.position = pos;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Destroy(gameObject);
            x = Random.Range(-rangeX, rangeX);
            y = Random.Range(-rangeY, rangeY);

            pos = new Vector2(x, y);

            transform.position = pos;
        }
    }
}
