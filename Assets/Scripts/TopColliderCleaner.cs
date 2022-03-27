using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopColliderCleaner : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }
}
