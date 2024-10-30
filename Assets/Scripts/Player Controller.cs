using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerControle controls;
    private Vector2 move;
    private Vector2 look;
    private CharacterController controller;
    private bool isJumping;
    private bool isSprinting;
    private bool isAiming;
    private bool isShooting;
    private bool isReloading;
    private float speed;
    private float animationBlend;
    private float targetRotation;
    private float rotationVelocity;
    private float verticalVelocity;

    public float moveSpeed = 5f;
    public float sprintSpeed = 10f;
    public float jumpForce = 5f;
    public float speedChangeRate = 10f;
    public float rotationSmoothTime = 0.12f;
    public Transform cameraTransform;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
        controls = new PlayerControle();

        // Bind actions
        controls.Land.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Land.Look.performed += ctx => look = ctx.ReadValue<Vector2>();
        controls.Land.Jump.performed += ctx => isJumping = true;
        controls.Land.Jump.canceled += ctx => isJumping = false;
        controls.Land.Sprinting.performed += ctx => isSprinting = true;
        controls.Land.Sprinting.canceled += ctx => isSprinting = false;
        // controls.Land.Aim.performed += ctx => isAiming = true;
        // controls.Land.Aim.canceled += ctx => isAiming = false;
        // controls.Land.Shoot.performed += ctx => isShooting = true;
        // controls.Land.Shoot.canceled += ctx => isShooting = false;
        // controls.Land.Reload.performed += ctx => isReloading = true;
        // controls.Land.Reload.canceled += ctx => isReloading = false;
    }

    void OnEnable()
    {
        controls.Land.Enable();
    }

    void OnDisable()
    {
        controls.Land.Disable();
    }

    void Update()
    {
        Move();
        Look();
        Jump();
        Aim();
        Shoot();
        Reload();
    }

    private void Move()
    {
        float targetSpeed = isSprinting ? sprintSpeed : moveSpeed;

        if (move == Vector2.zero) targetSpeed = 0.0f;

        float currentHorizontalSpeed = new Vector3(controller.velocity.x, 0.0f, controller.velocity.z).magnitude;
        float speedOffset = 0.1f;
        float inputMagnitude = move.magnitude;

        if (currentHorizontalSpeed < targetSpeed - speedOffset || currentHorizontalSpeed > targetSpeed + speedOffset)
        {
            speed = Mathf.Lerp(currentHorizontalSpeed, targetSpeed * inputMagnitude, Time.deltaTime * speedChangeRate);
            speed = Mathf.Round(speed * 1000f) / 1000f;
        }
        else
        {
            speed = targetSpeed;
        }

        animationBlend = Mathf.Lerp(animationBlend, targetSpeed, Time.deltaTime * speedChangeRate);

        if (animationBlend < 0.01f) animationBlend = 0f;

        Vector3 inputDirection = new Vector3(move.x, 0.0f, move.y).normalized;

        if (move != Vector2.zero)
        {
            targetRotation = Mathf.Atan2(inputDirection.x, inputDirection.z) * Mathf.Rad2Deg + cameraTransform.eulerAngles.y;
            float rotation = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetRotation, ref rotationVelocity, rotationSmoothTime);
            transform.rotation = Quaternion.Euler(0.0f, rotation, 0.0f);
        }

        Vector3 targetDirection = Quaternion.Euler(0.0f, targetRotation, 0.0f) * Vector3.forward;
        controller.Move(targetDirection.normalized * (speed * Time.deltaTime) + new Vector3(0.0f, verticalVelocity, 0.0f) * Time.deltaTime);
    }

    private void Look()
    {
        Vector3 rotation = new Vector3(0, look.x, 0) * 100f * Time.deltaTime;
        transform.Rotate(rotation, Space.Self);
    }

    private void Jump()
    {
        if (isJumping)
        {
            verticalVelocity = jumpForce;
            isJumping = false;
        }
    }

    private void Aim()
    {
        if (isAiming)
        {
            // Aim logic here
        }
    }

    private void Shoot()
    {
        if (isShooting)
        {
            // Shooting logic here
            isShooting = false;
        }
    }

    private void Reload()
    {
        if (isReloading)
        {
            // Reload logic here
            isReloading = false;
        }
    }
}
