using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMovement : MonoBehaviour
{
    public float speed = 5;
    GameplayController gameplayGameobject;

    private void Start()
    {
        gameplayGameobject = GameObject.Find("GameController").GetComponent<GameplayController>();
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameplayGameobject.incrementScore();
            Destroy(gameObject);
        }
    }
}
