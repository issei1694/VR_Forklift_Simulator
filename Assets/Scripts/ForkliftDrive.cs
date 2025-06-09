using UnityEngine;

public class ForkliftDrive : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 200f;
    public float turnSpeed = 150f;

    void FixedUpdate()
    {
        float moveInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal");

        Vector3 move = transform.forward * moveInput * moveSpeed * Time.fixedDeltaTime;
        Quaternion turn = Quaternion.Euler(0f, turnInput * turnSpeed * Time.fixedDeltaTime, 0f);

        rb.MovePosition(rb.position + move);
        rb.MoveRotation(rb.rotation * turn);
    }
}
