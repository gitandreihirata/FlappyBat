using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Drawing;
public class S_Player : MonoBehaviour
{
    public float velocity = 2.4f;
    private Rigidbody2D rigidbody;
    public int Point;
    int pontuacao;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rigidbody.linearVelocity = Vector2.up * velocity;
        }
    }
    public S_GameManager gameManager;
    public bool isDead = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        gameManager.GameOver();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("point"))
        {
            Point++;
            scoreText.text = Point.ToString();
            Debug.Log("Ponto Colidido!");
        }
    }
}
