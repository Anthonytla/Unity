using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public float spd = 5f;

    private Animator animator;
    Vector2 movement;
    public Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        bool mvHoz = false;
        bool mvVer = false;
        
        float xPos = 0, yPos = 0;
        animator = GetComponent<Animator>();
        
        if (Input.GetAxisRaw("Vertical") != 0 && Input.GetAxisRaw("Horizontal") != 0)
        {
            if (mvHoz)
            {
                yPos = Input.GetAxisRaw("Vertical");
            }
            else if (mvVer)
            {
                xPos = Input.GetAxisRaw("Horizontal");
            }
        }
        else
        {
            mvHoz = Input.GetAxisRaw("Horizontal") != 0;
            xPos = Input.GetAxisRaw("Horizontal");
            mvVer = Input.GetAxisRaw("Vertical") != 0;
            yPos = Input.GetAxisRaw("Vertical");
        }
        
        movement.x = xPos;
        movement.y = yPos;
        animator.SetFloat("Horizontal", xPos);
        animator.SetFloat("Vertical", yPos);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        //transform.position += new Vector3(xPos, yPos, 0).normalized * spd * Time.deltaTime;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * spd * Time.fixedDeltaTime);
    }
}
