using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("F*ck!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Package") && hasPackage == false)
        {
            hasPackage = true;
            Debug.Log("Package picked up!");
        }else if (collision.CompareTag("Customer") && hasPackage)
        {
            hasPackage = false;
            Debug.Log("Delivered package.");
        }
    }
}
