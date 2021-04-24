using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPosition : MonoBehaviour
{

    public int limitX = 200;
    public int limitY = 70;
    private Vector2 pos;
    private int x, y, z;
    
    void Start()
    {
        x = Random.Range(-limitX, limitX);
        y = Random.Range(-limitY, limitY);
        pos = new Vector3(x, y, 1);

        transform.position = pos;

    }
}
