using System.Collections;
using UnityEngine;

public class TrashBehaviour : MonoBehaviour
{
    private TrashBinData data;

    private void Start()
    {
        data = TrashBinData.getInstance();
        StartCoroutine(trashGone());
    }

    private IEnumerator trashGone()
    {
        yield return new WaitForSeconds(5f);
        data.Live--;
        Destroy(gameObject);
    }
}
