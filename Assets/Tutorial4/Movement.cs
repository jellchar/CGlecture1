using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 15.0f;

    public float horizontalInput;

    public float verticalInput;

    private PlayerInput input;

    void Awake()
    {
        input = GetComponent<PlayerInput>();
    }

    void Update()
    {
        float horizontalInput = input.Horizontal;
        float verticalInput = input.Vertical;

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);
    }
}
