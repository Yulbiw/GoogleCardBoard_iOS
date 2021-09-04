using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookWalk : MonoBehaviour
{
    public Transform vrCamera;

    public float toggleAngle = 30.0f;

    public float speed = 3.0f;

    public bool moveForward;

    private int count = 0;

    private CharacterController cc;
    private float timer;
    private float timer1;

    public float stayTime = 3.0f;
    public float stayUnderwaterTime = 10.0f;



    // Use this for initialization
    void Start()
    {

        cc = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {

        timer1 += Time.deltaTime;
        //transform.position = new Vector3(Mathf.Clamp(vrCamera.rotation.x, 10.0F, 360.0F), transform.rotation.y, transform.rotation.z);

        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
            moveForward = true;

        }
        else
        {
            moveForward = false;

        }

        if (moveForward)
        {

            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward * speed);


        }
        if (vrCamera.transform.position.y < -30.0f)
        {
            timer += Time.deltaTime;
            if (timer >= stayUnderwaterTime)
            {
                transform.position = new Vector3(391.0f, 2.0f, 383.0f);
                timer = 0.0f;
            }
        }

        //summer	
        if (transform.position.x > 690.0f && transform.position.x < 750.0f && transform.position.z > 480.0f && transform.position.z < 520.0f)
        {
            timer += Time.deltaTime;

            if (timer >= stayTime)
            {

                transform.position = new Vector3(-1014.0f, 2.0f, 607.0f);
                Debug.Log(timer);
                timer = 0.0f;
                count += 1;
            }
        }
        //winter
        if (transform.position.x > -1050.0f && transform.position.x < -970.0f && transform.position.z < 470.0f && transform.position.z > 380.0f)
        {
            timer += Time.deltaTime;

            if (timer >= stayTime)
            {

                transform.position = new Vector3(2051.0f, 2.0f, 300.0f);
                Debug.Log(timer);
                timer = 0.0f;
                count += 1;
            }
        }
        //spring
        if (transform.position.x > 1925.0f && transform.position.x < 2025.0f && transform.position.z < 500.0f && transform.position.z > 410.0f)
        {
            timer += Time.deltaTime;

            if (timer >= stayTime)
            {

                transform.position = new Vector3(3776.0f, 2.0f, 470.0f);
                Debug.Log(timer);
                timer = 0.0f;
                count += 1;
            }
        }
        //autumn
        if (transform.position.x > 3900.0f && transform.position.x < 4000.0f && transform.position.z < 180.0f && transform.position.z > 80.0f)
        {
            timer += Time.deltaTime;

            if (timer >= stayTime)
            {

                transform.position = new Vector3(391.0f, 2.0f, 383.0f);
                Debug.Log(timer);
                timer = 0.0f;
                count += 1;
            }
        }



    }
}
