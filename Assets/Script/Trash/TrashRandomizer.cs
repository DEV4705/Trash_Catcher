using System.Collections;
using UnityEngine;

public class TrashRandomizer : MonoBehaviour
{
    [SerializeField] private GameObject[] foodWaste;
    [SerializeField] private GameObject[] metalWaste;
    [SerializeField] private GameObject[] paperWaste;
    [SerializeField] private GameObject[] plasticWaste;

    [SerializeField] private float start;
    [SerializeField] private float end;

    private int trashIdx;

    private void Start()
    {
        StartCoroutine(spawner());
    }

    private int randomizerType()
    {
        return Random.Range(0, 4);
    }

    private int randomizerTrash(GameObject[] trashes)
    {
        int length = trashes.Length;
        return Random.Range(0, length);
    }

    private IEnumerator spawner()
    {
        while (true)
        {
            var range = Random.Range(start, end);
            var rand = randomizerType();

            if(rand == 0)//food waste
            {
                trashIdx = randomizerTrash(foodWaste);
                GameObject trash = Instantiate(foodWaste[trashIdx], new Vector3(range, 6, 0), Quaternion.identity);
            }
            else if (rand == 1)//metal waste
            {
                trashIdx = randomizerTrash(metalWaste);
                GameObject trash = Instantiate(metalWaste[trashIdx], new Vector3(range, 6, 0), Quaternion.identity);
            }
            else if(rand == 2)//paper waste
            {
                trashIdx = randomizerTrash(paperWaste);
                GameObject trash = Instantiate(paperWaste[trashIdx], new Vector3(range, 6, 0), Quaternion.identity);
            }
            else if(rand == 3)//plastic waste
            {
                trashIdx = randomizerTrash(plasticWaste);
                GameObject trash = Instantiate(plasticWaste[trashIdx], new Vector3(range, 6, 0), Quaternion.identity);
            }

            //notes buat randomizernya manual
            yield return new WaitForSeconds(3);
        }
    }
}
