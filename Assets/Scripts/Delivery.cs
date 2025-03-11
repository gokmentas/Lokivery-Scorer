using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float destroyDelay = 0f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("F*ck!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Package") && !hasPackage)
        {
            hasPackage = true;
            Destroy(collision.gameObject, destroyDelay);
            Debug.Log("Package picked up!");
        }else if (collision.CompareTag("Customer") && hasPackage)
        {
            hasPackage = false;
            Debug.Log("Delivered package.");
        }
    }
}
