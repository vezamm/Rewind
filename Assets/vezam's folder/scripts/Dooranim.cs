using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dooranim : MonoBehaviour
{
    public Animator animator;
    public bool dooropen;
    public AudioSource open;
    // Start is called before the first frame update
    void Start()
    {
        dooropen = animator.GetBool("open");
    }
    private void FixedUpdate()
    {
        dooropen=animator.GetBool("open");
    }
    public void OpenD()
    {
        if (!dooropen)
        {
            animator.SetBool("open", true);
            if (open != null && !open.isPlaying)
            {
                open.Play();
            }
        }
        else animator.SetBool("open", false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
