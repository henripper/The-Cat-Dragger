using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 500f;
    public float sidewaysForce = 500f;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        // Add a forward foce
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Add a force of 200 on the z-axis
        if (Input.GetKey("w"))
        {
            rb.AddForce( 0, 0, 5f, ForceMode.VelocityChange);
        }
        if ( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
