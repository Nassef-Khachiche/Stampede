using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    private float MoveX, MoveZ;
    //sd is movement speed
    public float sd;
    public float JumpForce;
    public bool IsGrounded;
    public Rigidbody rb;
    //ms is mouse speed
    public int ms;
    public Transform cam;
    private float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * ms * 10 * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * ms * 10 * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -25f, 25f);

        cam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        
        this.gameObject.transform.Rotate(Vector3.up * mouseX);

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        MoveX = Input.GetAxis("Horizontal");
        MoveZ = Input.GetAxis("Vertical");

        rb.MovePosition(transform.position + (transform.forward * MoveZ * sd / 2) + (transform.right * MoveX * sd / 2));
    }
}
