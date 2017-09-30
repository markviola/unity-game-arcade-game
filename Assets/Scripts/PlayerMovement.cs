using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Use this for initialization
    void Start () {
        Debug.Log("In Start\n");
        //rb.AddForce(0, 200, 500);
	}
	
	// Update is called once per frame
	void Update () {
        //rb.AddForce(0, 0, 2000*Time.deltaTime);
	}

    // Use for Unity physics
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -4f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
