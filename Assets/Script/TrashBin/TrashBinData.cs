using UnityEngine;

[CreateAssetMenu(fileName = "TrashBinData", menuName = "Scriptable Objects/TrashBinData")]
public class TrashBinData : ScriptableObject
{
    //TrashBin data
    private float speed = 5.5f;
    private int score = 0;

    //Dash
    private float dashSpeed = 35f;
    private float dashDuration = 0.1f;
    private float dashCooldown = 0.75f;
    private bool isDashing;
    private float dashTime;
    private float dashCooldownTimer;
    private float dashDirection;

    //Types
    private bool foodWaste = false;
    private bool paperWaste = false;
    private bool plasticWaste = false;
    private bool metalWaste = true;

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
    public float DashSpeed { get { return dashSpeed; } set { dashSpeed = value; } }
    public float DashDuration { get { return dashDuration; } set { dashDuration = value; } }
    public float DashCooldown { get { return dashCooldown; } set { dashCooldown = value; } }
    public bool IsDashing { get { return isDashing; } set { isDashing = value; } }
    public float DashTime { get { return dashTime; } set { dashTime = value; } }
    public float DashCooldownTimer { get { return dashCooldownTimer; } set { dashCooldownTimer = value; } }
    public float DashDirection { get { return dashDirection; } set { dashDirection = value; } }

    //notes ini cara pakenya nanti di kelas lain tinggal bikin [TrashBinData tb = TrashBinData.getInstance();]
}
