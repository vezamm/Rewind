using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.AssemblyQualifiedNameParser;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float Playerspeed = 1.0f;
    [SerializeField]
    private float playerSprintspeed = 2.0f;
    [SerializeField]
    private float jumpheight = 1.0f;
    [SerializeField]
    private float gravityvalue = -9.81f;
    [SerializeField]
    private float rotationspeed = 4f;
    [SerializeField]
    private bool Grounded;


    private CharacterController characterController;
    private Vector3 playerVelocity;
    private PlayerControle _playercontrole;
    private Transform cameraMaintransform;
    private void Awake()
    {
        _playercontrole=new PlayerControle();
    }
    private void OnEnable()
    {

        _playercontrole.Enable();
    }
    private void OnDisable()
    {

        _playercontrole.Disable();
    }
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        characterController =gameObject.GetComponent<CharacterController>();
        cameraMaintransform=Camera.main.transform;
    }

    void Update()
    {
        Grounded = characterController.isGrounded;
        if (Grounded && playerVelocity.y < 0)
        {
            playerVelocity.y = 0;
        }
        Vector2 movement = _playercontrole.Land.Move.ReadValue<Vector2>();
        Vector3 move = new Vector3(movement.x, 0,movement.y) ;

        move = cameraMaintransform.forward * move.z + cameraMaintransform.right * move.x;
        move.y = 0;

        Debug.Log(move);

        if (_playercontrole.Land.Jump.triggered && Grounded)
        {
            playerVelocity.y=Mathf.Sqrt(jumpheight*-3.0f*gravityvalue);
        }

        playerVelocity.y += gravityvalue * Time.deltaTime;
        characterController.Move(playerVelocity*Time.deltaTime);

        if ( _playercontrole.Land.Sprinting.IsPressed())
        {
            characterController.Move(move * Time.deltaTime * playerSprintspeed);
        }
        else
           characterController.Move(move*Time.deltaTime*Playerspeed);
        if(movement!=Vector2.zero)
        {
            float targetangle=Mathf.Atan2(movement.x,movement.y)*Mathf.Rad2Deg+cameraMaintransform.eulerAngles.y;
            Quaternion rotation = Quaternion.Euler(0f,targetangle,0f);
            transform.rotation=Quaternion.Lerp(transform.rotation,rotation,Time.deltaTime*rotationspeed);
        }
        
    }
}
