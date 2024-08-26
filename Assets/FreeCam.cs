using UnityEngine;

public class FreeCam : MonoBehaviour
{
    public float movementSpeed = 10.0f;   // Speed of camera movement
    public float lookSpeed = 2.0f;        // Speed of camera rotation
    public float sprintMultiplier = 2.0f; // Speed multiplier when holding Shift

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    void Update()
    {
        // Mouse input for looking around
        yaw += lookSpeed * Input.GetAxis("Mouse X");
        pitch -= lookSpeed * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        // Keyboard input for movement
        float speed = movementSpeed * (Input.GetKey(KeyCode.LeftShift) ? sprintMultiplier : 1.0f);

        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.Q))
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.E))
            transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
