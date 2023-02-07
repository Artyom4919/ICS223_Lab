using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float horizInput;
    private float vertInput;
    private int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizInput = Input.GetAxis("Horizontal");
        vertInput = Input.GetAxis("Vertical");
    }


    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(horizInput,0, vertInput) * Time.deltaTime * speed * 100;
        rb.velocity = movement;
    }
}
