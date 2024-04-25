using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigController : MonoBehaviour
{
    private Rigidbody2D myRB;
    private float myVelocity = 2f;
    private float waitMove = 1f;
    private int direction;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        direction = Random.Range(-1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        waitMove -= Time.deltaTime;
        if (waitMove <= 0f)
        {
            myRB.velocity = new Vector2(myVelocity * direction, 0f);
            if (myRB.velocity.x != 0f)
            {
                transform.localScale = new Vector3(Mathf.Sign(myRB.velocity.x) * -1, 1f, 1f);
            }
            waitMove = Random.Range(2, 3);
            direction = Random.Range(-1, 2);
        }
    }
}
