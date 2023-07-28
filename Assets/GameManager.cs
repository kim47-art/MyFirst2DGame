using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Block[] blocks;
    public GameObject gameOverUI;
    public GameObject gameClearUI;
    public Ball ball;

    private bool isGameClear = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameClear != true)
        {
            //Blockが全部消えたら、ゲームクリア
            if (DestroyAllBlocks())
            {
                Destroy(ball.gameObject);
                Debug.Log("ゲームクリア");
                gameClearUI.SetActive(true);
                isGameClear = true;
            }
        }
    }

    private bool DestroyAllBlocks()
    {
        foreach (Block block in blocks)
        {
            if (block != null)
            {
                return false;
            }
        }
        return true;
    }

    public void GameOver() 
    { 
        Debug.Log("ゲームオーバー");
        gameOverUI.SetActive(true);
        
    }

    public void GameRetry()
    {
        //Sceneを再びよみこんで、
        SceneManager.LoadScene("Scenes/SampleScene");
    }

}
