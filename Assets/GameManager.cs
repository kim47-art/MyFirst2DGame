using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Block[] blocks;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Blockが全部消えたら、ゲームクリア
        if(DestroyAllBlocks())
        {
            Debug.Log("ゲームクリア");
        }
        //Ballが下に着いたら、ゲームオーバー
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
    }

    public void Reset()
    {
        //Sceneを再びよみこんで、
        SceneManager.LoadScene("game");
    }

}
