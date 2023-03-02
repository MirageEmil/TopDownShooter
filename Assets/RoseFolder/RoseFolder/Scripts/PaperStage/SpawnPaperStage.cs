using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPaperStage : MonoBehaviour
{
    public GameObject paperStage;
    public Gamemanager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<Gamemanager>();

        if (gameManager.isGameActive)
        {
            StartCoroutine("SpawnpaperStage");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator SpawnpaperStage()
    {
        Vector2 spawnPos = new Vector2(transform.position.x, transform.position.y);
        Instantiate(paperStage, spawnPos, paperStage.transform.rotation);
        yield return new WaitForSeconds(2);
        StartCoroutine("SpawnpaperStage");
    }

}
