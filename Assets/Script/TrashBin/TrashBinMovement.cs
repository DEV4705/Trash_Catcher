using UnityEngine;

public class TrashBinMovement : MonoBehaviour
{
    //Trash bin
    private Rigidbody2D rb;
    private TrashBinData data;

    //Movement
    private float dir;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        data = TrashBinData.getInstance();
    }

    // Update is called once per frame
    private void Update()
    {
        move();
    }

    private void move()
    {
        dir = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(dir * data.Speed, rb.linearVelocity.y);
    }
}
