using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private float horizontal;
    private float speed = 4f;
    private float jumpingPower = 8f;
    private bool isFacingRight = true;
    public bool isInSafety = false;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    [SerializeField] private PhysicsMaterial2D NoFrictionMat;
    [SerializeField] private PhysicsMaterial2D FrictionMat;

    [SerializeField] private AudioClip jumpSound;
    [SerializeField] private AudioClip flickSwitch;

    //used to make Terry visually change when deactivated
    public GameObject terry_image_activated;
    public GameObject terry_image_deactivated;

    private void Start()
    {
        //replace with different sprites
        //this.GetComponent<SpriteRenderer>().color = Random.ColorHSV();
        ToggleVisualActivation(true);
    }

    private void ToggleVisualActivation(bool isActivated)
    {
        terry_image_activated.GetComponent<Renderer>().enabled = isActivated;
        terry_image_deactivated.GetComponent<Renderer>().enabled = !isActivated;

        if(!isActivated)
        {
            gameObject.GetComponent<BoxCollider2D>().sharedMaterial = FrictionMat;
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            if (!isInSafety)
            {
                DisablePlayer();
                SoundFXManager.instance.PlaySoundFXCLip(flickSwitch, rb.transform, 1f);
            }
        }

        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            SoundFXManager.instance.PlaySoundFXCLip(jumpSound, rb.transform, 1f);
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
        if (terry_image_activated.GetComponent<Renderer>().enabled)
        {
            FindAnyObjectByType<SpawnPlayer>().Spawn();
            gameObject.layer = 6;
            rb.velocity = Vector3.zero;
            gameObject.GetComponent<BoxCollider2D>().sharedMaterial = NoFrictionMat;
            gameObject.GetComponent<PlayerScript>().enabled = false;
            ToggleVisualActivation(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("DeathZone"))
        {
            DisablePlayer();
            SoundFXManager.instance.PlaySoundFXCLip(flickSwitch, rb.transform, 1f);
        }
    }
}
