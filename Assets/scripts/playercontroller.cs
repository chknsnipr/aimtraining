using UnityEngine;
using UnityEngine.Rendering;

public class playercontroller : MonoBehaviour
{
    [Header("Mouse Look Sensitivity")]
    public static float mouseSensitivity = 100f;
    [SerializeField] private Transform cameraTransform;
    public float maxLookAngle = 90f;

    public static bool isshooting = true;

    private float mouseX;
    private float mouseY;

    private float xRotation = 0f;

    public static int score = 0;

    public static bool wavestart = false;

    public static int bestscore = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {

        Cursor.lockState = CursorLockMode.Locked;
    }

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        HandleMouseLook();
        shootingmech();
        if (Input.GetKey(KeyCode.Q))
        {
            wavestart = true;
        }


    }
    void shootingmech()
    {
        isshooting = Input.GetMouseButton(0);

    }
    private void HandleMouseLook()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -maxLookAngle, maxLookAngle);

        cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
        if (Input.GetKey(KeyCode.UpArrow) )
        {
            mouseSensitivity += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow) && mouseSensitivity >= 1)
        {
            mouseSensitivity -= 1;
        }
        
        
    }
    

}
