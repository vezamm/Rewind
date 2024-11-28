using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class openningclosing : MonoBehaviour
{
    [SerializeField] private Dooranim anim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("door") )
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Dooranim door = other.GetComponent<Dooranim>();
                door.OpenD();
            }
        }
        if (other.CompareTag("ball"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(other);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
