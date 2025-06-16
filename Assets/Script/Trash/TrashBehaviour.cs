using UnityEngine;

public class TrashBehaviour : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 5f);
    }
}
