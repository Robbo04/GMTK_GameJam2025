using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 8;
    public float jumpScale = 8;
    public float xInput;
    Rigidbody2D playerRB;
    [SerializeField] GameObject player;
    [SerializeField] Sprite playerSprite; 

    // Start is called before the first frame update
    void Start()
    {
        playerRB = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        Movement();
    }


    void CheckInput()
    {
        xInput = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;        
        
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        if (Input.GetButtonDown("Cancel"))
        {
            print("Quit");
            Application.Quit();
        }
    }

    void Jump()
    {
        playerRB.AddForce(Vector2.up * jumpScale, ForceMode2D.Impulse);
        print("Jump");
    }

    void Movement()
    {
        transform.Translate(xInput, 0, 0);
        
    }
}
