using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    private float speed = 20f;
    private float UpInput;
    private float DownInput;
    private float turnSpeed = 60;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpInput = Input.GetAxis("Vertical");
        DownInput = Input.GetAxis("Vertical");

        // up
        transform.Translate(Vector3.up * Time.deltaTime * speed * UpInput);
        transform.Rotate(Vector3.up, turnSpeed * UpInput * Time.deltaTime);

        // down
        transform.Translate(Vector3.down * Time.deltaTime * speed * DownInput);
        transform.Rotate(Vector3.down, turnSpeed * DownInput * Time.deltaTime);

        // auto move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
