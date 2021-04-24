using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float force = 50f;
    public int count;
    public int score;
    public float timer = 0;
    public float TimeStamp;

    private Vector3 velocity = Vector3.zero;
    private Rigidbody2D rb2d;
    public CharacterController controller;
    public GameOverScreen gameOverScreen;
    public Time time;

    public float speed = 50f;
    public float rotateSpeed = 300f;
    public Transform target;

    public int maxHealth = 20;
    public int health;
    public HealthBar healthBar;
    public UpdateScore updScr;

    public Joystick joystick;

    private void Awake()
    {
        TimeStamp = 0;
        timer = 0;
        count = 1;
        score = 0;
        rb2d = GetComponent<Rigidbody2D>();
        healthBar.SetHealthMax(maxHealth);
        health = maxHealth;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer = Time.timeSinceLevelLoad;
       /* if(timer >= 10 )
        {
            Time.
        }
       */
        float factorX = joystick.Horizontal * force;
        float factorY = joystick.Vertical * force;
            
        if (Input.GetMouseButton(0))
        {
            rb2d.AddForce(new Vector2(0f, factorY));
        }
            //if (Input.GetKey(KeyCode.A))
        if (Input.GetMouseButton(0))
        {
            rb2d.AddForce(new Vector2(factorX, 0f));
        }
        updScr.UpdateData(score, timer);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (health == 2 | health == 0 | health == 1)
        {
            TimeStamp = timer;
            force = 0f;
            gameOverScreen.Setup(score, TimeStamp);
        }

        if (collision.gameObject.tag == "TwoHitMissile")
        {
            health -= 4;
            healthBar.SetHealth(health);
        }else if (collision.gameObject.tag == "FiveHitMissile")
        {
            health -= 2;
            healthBar.SetHealth(health);    
        } else if (collision.gameObject.tag == "CoinNormal")
        {
            health += 2;
            score += 5;
            if (health > 20)
            {
                health = 20;
                healthBar.SetHealth(health);
            }
            else
            {
                healthBar.SetHealth(health);
            }
            
        }
        else if (collision.gameObject.tag == "CoinFullRegen")
        {
            healthBar.SetHealth(maxHealth);
            score += 25;
        }


        if (health > 20)
        {
            health = 20;
            healthBar.SetHealth(health);
        }
    }
}
