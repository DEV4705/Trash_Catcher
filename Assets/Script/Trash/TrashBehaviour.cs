using UnityEngine;

public class TrashBehaviour : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("ground"))
        {
            Destroy(gameObject);
        }
    }
}
