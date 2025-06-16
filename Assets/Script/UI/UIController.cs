using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private GameObject cooldown;
    private TrashBinData data;

    private void Start()
    {
        data = TrashBinData.getInstance();
    }

    // Update is called once per frame
    private void Update()
    {
        score.text = data.Score.ToString();
        
        if(data.DashCooldownTimer >= 0)
        {
            cooldown.SetActive(false);
        }
        else
        {
            cooldown.SetActive(true);
        }
    }
}
