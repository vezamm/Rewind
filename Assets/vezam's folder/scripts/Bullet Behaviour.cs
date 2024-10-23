using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] private float Bulletspeed = 50;
    //[SerializeField] Shooting _Shooting;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Invoke("DestroyBullets", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        rb.velocity=transform.forward*Bulletspeed*10;
    }
    public void DestroyBullets()
    {
        Destroy(gameObject);
        Debug.Log("destroyd");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("wall"))
        {
            Destroy(gameObject);
            Debug.Log("wallhit");
        }
    }
}
