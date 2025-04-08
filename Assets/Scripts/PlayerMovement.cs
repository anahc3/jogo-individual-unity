using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private AudioSource audioSource;

    public float speed; 
    public AudioClip audioFlower;     
    public AudioClip audioGameOver;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // pega o rigidbody2D do player
        audioSource = GetComponent<AudioSource>(); // pega o audio source do player
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameController.GameOver) // se o jogo estiver em game over
        {
            rb.linearVelocity = Vector2.zero;
            return; // não faz nada
        }

        float moveHorizontal = Input.GetAxis("Horizontal"); 
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);
    }

    /// Sent when another object enters a trigger collider attached to thio object (2D physics only)
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "coletavel") 
        {
            audioSource.PlayOneShot(audioFlower); // toca o som de coletar
            GameController.Collect(); // chama o método Collect do GameController
            Destroy(other.gameObject); // destroi o objeto coletável
        }

        if (other.CompareTag("inimigo")) // abelha
        {
            audioSource.PlayOneShot(audioGameOver);
            GameController.HitByEnemy();
        }
    }
}
