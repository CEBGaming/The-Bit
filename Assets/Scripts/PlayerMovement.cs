using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float speed = 5;
    private Vector3 playerInput;
    public Rigidbody2D myBody;
    public float HeightJump = 10f;
    public int num = 0;

    public Animator animator;

    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        playerInput = Vector2.zero;
        playerInput.x = Input.GetAxisRaw("Horizontal");
        //playerInput.y = Input.GetAxisRaw("Vertical");

        //animator.SetFloat("Horizontal", playerInput.x);
        //animator.SetFloat("Vertical", playerInput.y);
        //animator.SetFloat("Speed", playerInput.magnitude);

    }

    private void FixedUpdate()
    {
        myBody.MovePosition(transform.position + playerInput * speed * Time.fixedDeltaTime);

    }



}
