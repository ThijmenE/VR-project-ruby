using UnityEngine;

public class DartRotation : MonoBehaviour
{
    private Rigidbody rb;
    private bool isFlying = false;
    private float currentSpinAngle = 0f;
    private Vector3 initialForwardDirection; 

    [SerializeField] private float rotationSpeed = 2f; 
    [SerializeField] private float spinSpeed = 1080f;
    [SerializeField] private float liftFactor = 0.5f;  

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnDartReleased()
    {
        isFlying = true;
        currentSpinAngle = 0f;

        initialForwardDirection = transform.up;

        if (rb.linearVelocity.sqrMagnitude > 0.1f)
        {
            Vector3 throwDir = rb.linearVelocity.normalized;
            if (Vector3.Dot(throwDir, initialForwardDirection) > 0.5f)
            {
                rb.linearVelocity = initialForwardDirection * rb.linearVelocity.magnitude;
            }
        }
    }

    void FixedUpdate()
    {
        if (isFlying)
        {
            Vector3 liftAmount = Vector3.up * (Physics.gravity.magnitude * liftFactor);
            rb.AddForce(liftAmount, ForceMode.Acceleration);

            if (rb.linearVelocity.sqrMagnitude > 0.1f)
            {
                Vector3 blendedDirection = Vector3.Lerp(initialForwardDirection, rb.linearVelocity.normalized, 0.3f).normalized;

                Quaternion lookRotation = Quaternion.LookRotation(blendedDirection) * Quaternion.Euler(90, 0, 0);

                currentSpinAngle += spinSpeed * Time.fixedDeltaTime;
                Quaternion spinRotation = Quaternion.AngleAxis(currentSpinAngle, Vector3.up);

                Quaternion targetRotation = lookRotation * spinRotation;

                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        isFlying = false;
    }
}
