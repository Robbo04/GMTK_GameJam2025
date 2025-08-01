using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerScript : MonoBehaviour
{
    private float horizontal;
    private float speed = 4f;
    private float jumpingPower = 8f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    [SerializeField] private PhysicsMaterial2D noFrictionMat;

    private void Start()
    {
        //replace with different sprites
        //this.GetComponent<SpriteRenderer>().color = Random.ColorHSV();
    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            DisablePlayer();
        }

        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        //print(IsGrounded());
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    private void DisablePlayer()
    {
        FindAnyObjectByType<SpawnPlayer>().Spawn();
        gameObject.layer = 6;
        rb.velocity = Vector3.zero;
        gameObject.GetComponent<BoxCollider2D>().sharedMaterial = noFrictionMat;
        gameObject.GetComponent<PlayerScript>().enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("DeathZone"))
        {
            DisablePlayer();
        }
    }
}
