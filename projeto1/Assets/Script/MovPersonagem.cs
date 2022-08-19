using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonagem : MonoBehaviour
{
    private CharacterController controller;
    private Animator anim;

    [Header ("Config Player")]
    public float movimentSpeed = 3f;

    private Vector3 direction;
    private bool isWalk;


    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();

    }

    void Update()
    {
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        direction = new Vector3(horizontal, 0f, vertical).normalized;
    
        if (direction.magnitude > 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, targetAngle, 0);
            isWalk = true;
        }
        else
       {
            isWalk = false;
       }

        controller.Move(direction * movimentSpeed * Time.deltaTime);
        UpdateAnimator();

    }

    void UpdateAnimator()
    {
        anim.SetBool("isWalk" , isWalk);
    }

    void MoveChraracter()
    {

    }


}
