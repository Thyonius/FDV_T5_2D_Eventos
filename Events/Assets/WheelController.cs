using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    bool canSpin;
    HingeJoint2D hJoint;

    private void Start()
    {
        hJoint = GetComponent<HingeJoint2D>();
        canSpin = false;
        EventManager.current.OnClickedButton += ManageSpining;
    }

    private void Update()
    {
        Spin();
    }

    void ManageSpining()
    {
        canSpin = !canSpin;
    }

    void Spin()
    {
        if (canSpin)
        {
            hJoint.useMotor = true;
        }
        else
        {
            hJoint.useMotor = false;
        }
    }
}
