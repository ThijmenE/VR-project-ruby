using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CenterOfGravity : MonoBehaviour
{
    [Tooltip("Offset relative to the object's origin.")]
    public Vector3 CenterOfMass2;
    public bool IsAwake;

    protected Rigidbody r;

    void Start()
    {
        r = GetComponent<Rigidbody>();
        
        r.centerOfMass = CenterOfMass2;
        r.ResetInertiaTensor();
    }

    void Update()
    {
        IsAwake = !r.IsSleeping();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Vector3 worldCenterOfMass = transform.TransformPoint(CenterOfMass2);
        Gizmos.DrawSphere(worldCenterOfMass, 0.05f); 
    }
}
