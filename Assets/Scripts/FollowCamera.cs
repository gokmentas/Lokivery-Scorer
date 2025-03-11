using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject player;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + new Vector3(0, 0, -10);
    }
}
