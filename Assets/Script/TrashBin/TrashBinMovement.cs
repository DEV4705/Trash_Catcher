using System.ComponentModel;
using UnityEngine;

public class TrashBinMovement : MonoBehaviour
{
    //Trash bin
    [SerializeField] private GameObject trashBin;
    private SpriteRenderer sr;

    private Rigidbody2D rb;
    private TrashBinData data;
    private ChangeType changer;

    //Movement
    private float dir;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        data = TrashBinData.getInstance();
        changer = new ChangeType();
    }

    // Update is called once per frame
    private void Update()
    {
        move();
        changeType();
    }

    private void move()
    {
        dir = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(dir * data.Speed, rb.linearVelocity.y);
    }

    private void changeType()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            changer.changeToFoodWaste();
            sr.color = Color.green;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            changer.changeToPaperWaste();
            sr.color = Color.white;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            changer.changeToPlasticWaste();
            sr.color = Color.blue;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            changer.changeToMetalWaste();
            sr.color = Color.gray;
            //notes pergantian warna diganti sprite nantinya
        }
    }

}
