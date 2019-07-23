using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;
    public float speed = 0.0f;
    private float moveX;
    private float moveZ;
    public CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("pass");
        if (Input.GetButtonDown("A"))
        {
            Debug.Log("Aボタンが押されました");
            animator.SetBool("Attack", true);
        }
        if (Input.GetButtonDown("B"))
        {
            Debug.Log("Bボタンが押されました");
        }
        moveX = Input.GetAxis("Horizontal") * speed;
        moveZ = Input.GetAxis("Vertical") * speed;
        Vector3 direction = new Vector3(moveX, 0, moveZ);
        controller.Move(direction * Time.deltaTime);

    }// void Update()


}
