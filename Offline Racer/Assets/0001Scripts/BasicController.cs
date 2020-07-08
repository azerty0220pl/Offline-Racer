using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour
{
    public float speed;
    public float rotSpeed;
    public GameObject panel;

    // Start is called before the first frame update
    void Forward()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.VelocityChange);
    }

    void Stop()
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
        transform.position = new Vector3(0, 1.5f, 0);
        transform.eulerAngles = new Vector3(0, -90, 0);
    }

    public void turnLeft()
    {
            transform.Rotate(0, -rotSpeed, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.VelocityChange);
    }
    public void turnRight()
    {
            transform.Rotate(0, rotSpeed, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            GetComponent<Rigidbody>().AddForce(transform.forward * speed, ForceMode.VelocityChange);
    }
}
