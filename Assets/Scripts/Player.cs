using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController character;
    private Vector3 direction;

    public float gravity = 9.81f * 2f;
    public float jumpForce = 8f;
    public ParticleSystem dust;


    private void Awake()
    {
        character = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        direction = Vector3.zero;
    }
    private void Update()
    {
        direction += Vector3.down * gravity * Time.deltaTime;

        if (character.isGrounded)
        {
            CreateDust();
            direction = Vector3.down;
            if (Input.GetButton("Jump"))
            {
                SoundManagerScript.PlaySound("Jump");
                direction = Vector3.up * jumpForce;
            }
        }
        character.Move(direction * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacles"))
        {
            SoundManagerScript.PlaySound("Died");
            GameManager.Instance.GameOver();
        }
    }

    void CreateDust()
    {
        dust.Play();
    }
}
