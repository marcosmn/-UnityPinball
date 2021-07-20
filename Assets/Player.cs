using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    HingeJoint LeftFlipper;
    [SerializeField]
    HingeJoint RightFlipper;
    [SerializeField]
    Collider Spring;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Hurdle.motor = RotateFlipper(1500);

        if (Input.GetKey(KeyCode.D))
        {
            RightFlipper.motor = RotateFlipper(1500);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            RightFlipper.motor = RotateFlipper(-1500);
        }

        if (Input.GetKey(KeyCode.A))
        {
            LeftFlipper.motor = RotateFlipper(-1500);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            LeftFlipper.motor = RotateFlipper(1500);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Rigidbody corpo = Spring.GetComponent<Rigidbody>();
            corpo.AddForce(10 * Vector3.forward);
            //Spring.transform.Translate(Vector3.left * Time.deltaTime * 5);
        }
        else
        {
            Rigidbody corpo = Spring.GetComponent<Rigidbody>();
            corpo.AddForce(10 * Vector3.back);
        }
    }

    JointMotor RotateFlipper(float velocity, float force = 150)
    {
        JointMotor jointMotor = new JointMotor();
        jointMotor.force = force;
        jointMotor.targetVelocity = velocity;
        return jointMotor;
    }
}
