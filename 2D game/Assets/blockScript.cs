using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blockScript : MonoBehaviour
{

    public int healthPoint;
    public GameObject BlockText;

    // Start is called before the first frame update
    void Start()
    {
        healthPoint = Random.Range(1, 30);
    }

    // Update is called once per frame
    void Update()
    {
        BlockText.GetComponent<Text>().text = healthPoint.ToString();
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "bullet")
        {
            healthPoint -= 1;
        }
        if (healthPoint <= 1)
        {
            Destroy(gameObject);
        }
    }
}
