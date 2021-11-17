using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public GameObject blockPrefab;
    public List<GameObject> blocks;

    Vector2 blockPos;
    int amount = 16;
    float xPos, screenX;


    // Start is called before the first frame update
    void Start()
    {
        screenX = Vector2.Distance(
            Camera.Main.ScreenToWorldPoint(new Vector2(0, 0)),
            Camera.Main.ScreenToWorldPoint(new Vector2(screenX.width, 0))
            ) * 0.5f;

        SpawnBlocks();
    }

    
    void SpawnBlocks()
    {
        xPos = (Camera.Main.transform.position.x - screenX) + 0.5f;
        blockPos = new Vector2(xPos, 3f);
        for(int i = 0; i < amount; i++)
        {
            xPos += 1f;
            if(Random.Range(0, 100) > 30)
            {
                blockPos = new Vector2(xPos, 3f);
                blocks.Add(Instantiate(blockPrefab, blockPos, Quanternion.identity, transform));
            }
        }
    }

    void update()
    {

    }
}
