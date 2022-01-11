using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    Rigidbody2D rb2;
    bool onGround;
    float y;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onGround)
        {
            if (Input.GetMouseButton(0))
            {
                y = 20;
            }
            else
            {

            }
        }
        else
        {
            if (Input.GetMouseButton(0))
            {
                y -= 0.5f;
            }
            else
            {
                if(1 < y)
                {
                    y /= 2;
                }
                else
                {
                    y -= 0.5f;
                }
            }
        }



        rb2.velocity = new Vector2(0, y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        onGround = true;
        if(collision.gameObject.tag == "Obstacle")
        {
            //TODO ゲームオーバーの時の処理
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        onGround = false;
    }
}
