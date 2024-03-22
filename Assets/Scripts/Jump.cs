using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float Speed = 5f;
    public float SpeedJump = 8f;
    private float Direction = 0f;
    private Rigidbody2D MarinoBody;

    public Transform Check;
    public float CheckRadius;
    public LayerMask Ground;
    private bool TouchingGround;

    // Start is called before the first frame update
    void Start()
    {
        MarinoBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        TouchingGround = Physics2D.OverlapCircle(Check.position, CheckRadius, Ground);
        Direction = Input.GetAxis("Horizontal");

        if (Direction > 0f)
        {
            MarinoBody.velocity = new Vector2(Direction * Speed, MarinoBody.velocity.y);
        }
        else if (Direction < 0f)
        {
            MarinoBody.velocity = new Vector2(Direction * Speed, MarinoBody.velocity.y);
        }
        else
        {
            MarinoBody.velocity = new Vector2(0, MarinoBody.velocity.y);
        }

        if (Input.GetButtonDown("Jump") && TouchingGround)
        {
            MarinoBody.velocity = new Vector2(MarinoBody.velocity.x, SpeedJump);
        }
    }
}
