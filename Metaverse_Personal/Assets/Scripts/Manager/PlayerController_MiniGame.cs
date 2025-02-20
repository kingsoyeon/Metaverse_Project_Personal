using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_MiniGame : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator = null;
    Rigidbody2D _rigidbody = null;

    public float jumpForce = 6f;
    public float forwardSpeed = 11f;
    public bool isDead = false;
    float deathCooldown = 0f;

    bool isJump = false;

    public bool godMode = false;

    public GameManager gameManager = null;

    private Vector3 startPosition;

    void Start()
    {
        gameManager = GameManager.Instance;
        animator = transform.GetComponentInChildren<Animator>();
        _rigidbody = transform.GetComponent<Rigidbody2D>();

        if (animator == null)
        {
            Debug.LogError("Animator Null");
        }

        if (_rigidbody == null)
        {
            Debug.LogError("Rigidbody Null");
        }

        startPosition = transform.position;
    }


    void Update()
    {
        if (isDead)
        {
            if (deathCooldown <= 0)
            {
                if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
                {
                    // 게임 재시작
                }
            }
            else
            {
                deathCooldown -= Time.deltaTime;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                isJump = true;
            }
        }
    }

    public void FixedUpdate()
    {
        if (isDead)
            return;

        Vector3 velocity = _rigidbody.velocity;
        velocity.x = forwardSpeed;

        if (isJump)
        {
            velocity.y += jumpForce;
            isJump = false;
        }

        _rigidbody.velocity = velocity;

        float angle = Mathf.Clamp((_rigidbody.velocity.y * 10f), -90, 90);
        float lerpAngle = Mathf.Lerp(_rigidbody.velocity.y, angle, Time.deltaTime * 5f);
        transform.rotation = Quaternion.Euler(0, 0, lerpAngle);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (godMode)
            return;

        if (isDead)
            return;

        animator.SetInteger("isDead", 1);
        isDead = true;
        deathCooldown = 1f;
        gameManager.GameOver();
    }

    public void ResetPosition()
    {
        transform.position = startPosition;
    }
}
