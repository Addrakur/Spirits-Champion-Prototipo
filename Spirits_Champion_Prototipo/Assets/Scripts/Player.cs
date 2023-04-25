using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D playerRb;
    [SerializeField] float speed;
    public string spawnPoint;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        playerRb.velocity = new Vector2(horizontalInput * speed, verticalInput * speed);
    }

    /*private Rigidbody2D playerRb;
    [SerializeField] LayerMask groundLayer;

    private float direction;
    public float speed;
    public float jumpStrength;
    public float jumpStrengthModifier;
    public float startingJumpTime;
    public float currentJumpTime;

    public bool canJump;
    public bool isOnGround;
    public bool isAlive;


    BoxCollider2D boxCollider2D;

    void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();

        playerRb = GetComponent<Rigidbody2D>();

        isAlive = true;
    }

    void Update()
    {
        if(isAlive)
        {
        Movement();
        }

        GroundCheck();

    }

    //Checar se o player está no chão
    void GroundCheck()
    {

        float extraHeight = 0.1f;
        RaycastHit2D groundCheck = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, extraHeight,groundLayer);
        if (groundCheck.collider != null)
        {
            isOnGround = true;
            canJump = true;
            currentJumpTime = startingJumpTime;
        }
        else
        {
            isOnGround = false;
        }
    }

    #region Movement

    void Movement()
    {

        direction = Input.GetAxisRaw("Horizontal");

        // Movimenta o player de um lado para o outro
        playerRb.velocity = new Vector2(direction * speed, playerRb.velocity.y);

        // Faz o Player pular
        if (Input.GetKeyDown(KeyCode.W) && isOnGround)
        {
            playerRb.velocity = new Vector2(playerRb.velocity.x, jumpStrength);
        }

        // Pulo Dinamico
        if (Input.GetKey(KeyCode.W) && currentJumpTime > 0 && canJump)
        {
            playerRb.velocity = new Vector2(playerRb.velocity.x, jumpStrength * jumpStrengthModifier);
            currentJumpTime -= Time.deltaTime;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            canJump = false;
        }

        // Player olha para o lado que está andando
        if (direction < 0)
        {
            transform.eulerAngles = Vector2.up * 180;
        }
        if (direction > 0)
        {
            transform.eulerAngles = Vector2.up;
        }
    }

    #endregion*/
}