using UnityEngine;

[CreateAssetMenu(fileName = "TrashBinData", menuName = "Scriptable Objects/TrashBinData")]
public class TrashBinData : ScriptableObject
{
    private float speed = 5f;
    private int score = 0;

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

    //notes ini cara pakenya nanti di kelas lain tinggal bikin [TrashBinData tb = TrashBinData.getInstance();]
}
