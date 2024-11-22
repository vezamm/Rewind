using UnityEngine;

public class PlayerBoomerang : MonoBehaviour
{
    [serializefield] private Transform player; 
    [serializefield] private GameObject boomerang;
    [serializefield] private float throwForce = 10f;
    [serializefield] private float returnSpeed = 5f;
    [serializefield] private float flightTime = 2f; 
    [serializefield] private string actionInput = "Action 1";

    private Rigidbody boomerangRb;
    private bool isBoomerangEquipped = true; 
    private bool returning = false;

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
    }

    void ThrowBoomerang()
    {
        if (boomerangRb == null) return;

        Debug.Log("Throwing boomerang!");
        returning = false;
        boomerangRb.isKinematic = false;
        boomerangRb.velocity = transform.forward * throwForce;
        Invoke(nameof(StartReturning), flightTime);
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
