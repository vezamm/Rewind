using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoomerang : MonoBehaviour
{
    [SerializeField] private Transform player; 
    [SerializeField] private GameObject boomerang;
    [SerializeField] private float throwForce = 10f;
    [SerializeField] private float returnSpeed = 5f;
    [SerializeField] private float maxDistance = 20f; // Max distance for the boomerang to fly before returning
    [SerializeField] private string actionInput = "Action 1";
    [SerializeField] private LayerMask hitLayer; // Layer to check for hits

    private Rigidbody boomerangRb;
    private bool isBoomerangEquipped = true;
    private bool returning = false;
    private Vector3 throwDirection;
    private float distanceTraveled = 0f;

    void Start()
    {
        if (boomerang != null)
        {
            boomerangRb = boomerang.GetComponent<Rigidbody>();
        }
    }

    void Update()
    {
        if (Input.GetButtonDown(actionInput) && isBoomerangEquipped)
        {
            ThrowBoomerang();
        }

        if (returning)
        {
            ReturnBoomerang();
        }

        if (!returning && distanceTraveled < maxDistance)
        {
            distanceTraveled += boomerangRb.velocity.magnitude * Time.deltaTime;
        }
        else if (distanceTraveled >= maxDistance)
        {
            StartReturning();
        }
    }

    void ThrowBoomerang()
    {
        if (boomerangRb == null) return;

        Debug.Log("Throwing boomerang!");
        returning = false;
        distanceTraveled = 0f; // Reset distance
        boomerangRb.isKinematic = false;
        boomerangRb.velocity = transform.forward * throwForce;
        throwDirection = transform.forward; // Store the throw direction

        // Check for hits on the "Hit" layer
        RaycastHit hit;
        if (Physics.Raycast(boomerang.transform.position, throwDirection, out hit, maxDistance, hitLayer))
        {
            StartReturning();
        }
    }

    void StartReturning()
    {
        returning = true;
        boomerangRb.isKinematic = true;
    }

    void ReturnBoomerang()
    {
        if (boomerang == null) return;

        boomerang.transform.position = Vector3.MoveTowards(boomerang.transform.position, player.position, returnSpeed * Time.deltaTime);

        // Optionally rotate the boomerang while returning
        boomerang.transform.Rotate(Vector3.forward * 360 * Time.deltaTime);

        if (Vector3.Distance(boomerang.transform.position, player.position) < 0.5f)
        {
            returning = false;
            boomerangRb.isKinematic = false;
            boomerangRb.velocity = Vector3.zero;
            Debug.Log("Boomerang returned!");
        }
    }
}
