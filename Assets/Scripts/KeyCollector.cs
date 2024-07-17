using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCollector : MonoBehaviour
{
    public GameObject lastDoor; // 最後のドアのGameObjectを格納する変数
    private int keysCollected = 0; // 集めた鍵の数を管理する変数
    [SerializeField] Animator animator2;

    //public Text keysCollectedText; // 鍵の数を表示するためのテキストUI

    private void Start()
    {
        // 最後のドアのGameObjectを代入
        lastDoor = GameObject.FindGameObjectWithTag("lastDoor");

        // 鍵の数を表示するテキストを初期化
        //keysCollectedText.text = $"鍵: {keysCollected} / 3";
    }

    public void CollectKey()
    {
        keysCollected++;
        //keysCollectedText.text = $"鍵: {keysCollected} / 3";

        // 3つの鍵を集めたら、最後のドアを開く
        if (keysCollected == 3)
        {
            animator2.SetTrigger("lastDoorOpen");
            Debug.Log("最後のドアが開きました!");
            //Destroy(lastDoor);
        }

    }

    private void Update()
    {
    }
}