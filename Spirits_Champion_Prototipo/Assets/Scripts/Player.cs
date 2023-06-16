using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D playerRb;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] LayerMask plataformLayer;

    private float direction;
    public float speed;
    public float jumpStrength;
    public float jumpStrengthModifier;
    public float startingJumpTime;
    public float currentJumpTime;

    public bool goToSpawnPoint;
    public bool canJump;
    public bool isOnGround;
    public bool isAlive;

    public string spawnPoint;

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
        RaycastHit2D plataformCheck = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, extraHeight, plataformLayer);
        if (groundCheck.collider != null)
        {
            isOnGround = true;
            canJump = true;
            currentJumpTime = startingJumpTime;
        }
        else if(plataformCheck.collider != null)
        {
            isOnGround= true;
        }
        else
        {
            isOnGround = false;
        }

    }
    void SpawnPoint(string nextSpawnPoint)
    {
        spawnPoint = nextSpawnPoint;
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

    #endregion
}