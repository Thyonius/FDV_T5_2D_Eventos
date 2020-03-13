using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float leftPushRange;
    [SerializeField] float rightPushRange;
    [SerializeField] float velocityThreshold;
    bool canSwing;

    private void Start()
    {
        canSwing = false;
        rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = velocityThreshold;
        EventManager.current.OnClickedButton += StartSpinning;
    }

    private void Update()
    {
        Swing();
    }

    void StartSpinning()
    {
        canSwing = !canSwing;
    }

    void Swing()
    {
        if (canSwing)
        {
            if (transform.rotation.z > 0
                && transform.rotation.z < rightPushRange
                && rb.angularVelocity > 0 
                && rb.angularVelocity < velocityThreshold)
            {
                rb.angularVelocity = velocityThreshold;
            }
            else if (transform.rotation.z < 0
                && transform.rotation.z > leftPushRange
                && rb.angularVelocity < 0
                && rb.angularVelocity > velocityThreshold * -1)
            {
                rb.angularVelocity = velocityThreshold * -1;
            }
        }
    }
}
