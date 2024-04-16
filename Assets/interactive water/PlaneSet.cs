using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneSet : MonoBehaviour
{
    public float speed = 5f;
    private CharacterController controller;
    private Vector3 moveDirection;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Shader.SetGlobalVector("ObjectPosition", new Vector4(transform.position.x, transform.position.y, transform.position.z, transform.localScale.x));

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        moveDirection = new Vector3(horizontal, 0f, vertical);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;

        controller.Move(moveDirection * Time.deltaTime);

    }
}
