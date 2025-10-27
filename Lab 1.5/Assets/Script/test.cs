using UnityEngine;
using UnityEngine.InputSystem; // dùng Input System mới

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMoveNewInput : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Lấy input WASD từ Input System
        Keyboard kb = Keyboard.current;

        float x = 0, y = 0;
        if (kb.aKey.isPressed) x = -1;
        if (kb.dKey.isPressed) x = 1;
        if (kb.wKey.isPressed) y = 1;
        if (kb.sKey.isPressed) y = -1;

        moveInput = new Vector2(x, y).normalized;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveInput * speed;
    }
}
