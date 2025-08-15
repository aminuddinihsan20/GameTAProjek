using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;

    private PlayerControls playerControls;
    private Vector2 movement;
    private Rigidbody2D rb;
    private Animator myAnimator;
    private SpriteRenderer mySpriteRender;

    private void Awake()
    {
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        mySpriteRender = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void Update()
    {
        GetPlayerInput();
    }

 private void FixedUpdate()
    {
        // Terapkan fisika di FixedUpdate
        Move();
        AdjustPlayerFacingDirection();
    }

    private void GetPlayerInput()
    {
        movement = playerControls.Movement.Move.ReadValue<Vector2>();

        // Mengatur parameter animator untuk animasi gerak
        myAnimator.SetFloat("moveX", movement.x);
        myAnimator.SetFloat("moveY", movement.y);
    }

    private void Move()
    {
        // Menggerakkan karakter menggunakan Rigidbody
        Vector2 newPosition = rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(newPosition);
    }

    // --- FUNGSI YANG DIPERBARUI ---
    private void AdjustPlayerFacingDirection()
    {
        // Cek apakah ada input gerakan horizontal (kiri/kanan)
        if (movement.x > 0)
        {
            // Jika bergerak ke kanan, pastikan sprite tidak di-flip.
            mySpriteRender.flipX = false;
        }
        else if (movement.x < 0)
        {
            // Jika bergerak ke kiri, flip sprite-nya.
            mySpriteRender.flipX = true;
        }
    }
}
