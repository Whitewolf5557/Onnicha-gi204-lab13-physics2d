using UnityEngine;
using UnityEngine.InputSystem;

public class Player2DController : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 450;
    private Rigidbody2D _rb;
    private float _moveInputValue;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Keyboard.current != null)
        {
            _moveInputValue = (Keyboard.current.dKey.isPressed ? 1 : 0)
                - (Keyboard.current.aKey.isPressed ? 1 : 0);
        }
        _rb.linearVelocity = new Vector2(_moveInputValue * speed, _rb.linearVelocity.y);
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            _rb.AddForce(new Vector2(_rb.linearVelocity.x, jumpForce));
        }
    }
}
