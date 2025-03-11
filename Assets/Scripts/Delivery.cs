using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("F*ck!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Package"))
        {
            Debug.Log("Package picked up!");
        }else if (collision.CompareTag("Customer"))
        {
            Debug.Log("Delivered package.");
        }
    }
}
