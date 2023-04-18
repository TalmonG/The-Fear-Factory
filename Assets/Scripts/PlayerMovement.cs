using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Control Parameters")]
    //[SerializeField] Interact Interact;
    public CharacterController controller;
    public float speed;
    public float sprintSpeed;
    public float moveSpeed;
    public float gravity = -9.81f;
    public bool isSprinting = false;

    [Header("Camera")]
    private Camera playerCamera;

    [Header("Ground Checker")]
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float jumpHeight = 3f;
    bool isGrounded;

    Vector3 velocity;
    [Header("Headbobing")]
    [SerializeField] private bool canUseHeadbob = true;
    [SerializeField] private float walkBobSpeed = 5f;
    [SerializeField] private float walkBobAmount = 0.05f;
    [SerializeField] private float sprintBobSpeed = 10f;
    [SerializeField] private float sprintBobAmount = 10f;
    private float defaultYPos = 0;
    private float timer;

    [Header("Footstep Sound")]
    public GameObject footSteps;

    //public Interact RedKeyCardCollectable;
    //public Interact RedKeyCard;
    //public Interact Interact;
    //public Interact RedKeyCardCollected;



    void Awake()
    {
        playerCamera = GetComponentInChildren<Camera>();
        defaultYPos = playerCamera.transform.localPosition.y;
    }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        /*if (Input.GetKey(KeyCode.E) && RedKeyCardCollectable == true)
        {
            FindObjectOfType<AudioManager>().Play("Click");
            Interact.RedKeyCardCollected.SetActive(true);
            Destroy(RedKeyCard);
            Debug.Log("Doneeee");

        }*/

        /*if (canUseHeadbob)
        {
            HandleHeadbob();
        }*/

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * moveSpeed * Time.deltaTime);

        /*if (Input.GetButtonDown("Jump") && isGrounded)
        {


            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }*/

        if (canUseHeadbob = true && Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            canUseHeadbob = true;
            footSteps.SetActive(true);
            if (canUseHeadbob)
            {
                HandleHeadbob();
            }
        }
        else
        {
            footSteps.SetActive(false);
            canUseHeadbob = true;
        }
        /*if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            footSteps.SetActive(false);
        }*/

        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;

        }
        else
        {
            isSprinting = false;
        }

        if (isSprinting == true)
        {
            moveSpeed = sprintSpeed;
        }

        if (isSprinting == false)
        {
            moveSpeed = speed;
        }
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }

    private void HandleHeadbob()
    {
        timer += Time.deltaTime * (isSprinting ? sprintBobSpeed : walkBobSpeed);
        playerCamera.transform.localPosition = new Vector3(
            playerCamera.transform.localPosition.x,
            defaultYPos + Mathf.Sin(timer) * (isSprinting ? sprintBobAmount : walkBobAmount),
            playerCamera.transform.localPosition.z);
    }
}
