using UnityEngine;

[CreateAssetMenu(fileName = "TrashBinData", menuName = "Scriptable Objects/TrashBinData")]
public class TrashBinData : ScriptableObject
{
    //TrashBin data
    private float speed = 7f;
    private int score = 0;

    //Types
    private bool foodWaste = true;
    private bool paperWaste = false;
    private bool plasticWaste = false;
    private bool metalWaste = false;

    public static TrashBinData Instance;


    public static TrashBinData getInstance()
    {
        if (Instance == null)
        {
            Instance = ScriptableObject.CreateInstance<TrashBinData>();
        }
        return Instance;
    }

    public float Speed { get { return speed; } set { speed = value; }}
    public int Score { get { return score; } set { score = value; } }
    public bool FoodWaste { get { return foodWaste; } set { foodWaste = value; } }
    public bool PaperWaste { get { return paperWaste; } set { paperWaste = value; } }
    public bool PlasticWaste { get { return plasticWaste; } set { plasticWaste = value; } }
    public bool MetalWaste { get { return metalWaste; } set { metalWaste = value; } }

    //notes ini cara pakenya nanti di kelas lain tinggal bikin [TrashBinData tb = TrashBinData.getInstance();]
}
