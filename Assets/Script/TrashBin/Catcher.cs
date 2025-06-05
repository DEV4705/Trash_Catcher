using UnityEngine;

public class Catcher : MonoBehaviour
{
    private TrashBinData data;

    private void Start()
    {
        data = TrashBinData.getInstance();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("food") && data.FoodWaste)
        {
            Destroy(col.gameObject);
            //tambah score
        }
        else if(col.gameObject.CompareTag("metal") && data.MetalWaste)
        {
            Destroy(col.gameObject);
        }
        else if (col.gameObject.CompareTag("paper") && data.PaperWaste)
        {
            Destroy(col.gameObject);
        }
        else if (col.gameObject.CompareTag("plastic") && data.PlasticWaste)
        {
            Destroy(col.gameObject);
        }
    }
}
