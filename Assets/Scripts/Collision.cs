using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("F*ck!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("What?");
    }
}
