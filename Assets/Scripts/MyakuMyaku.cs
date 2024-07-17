using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyakuMyaku : MonoBehaviour
{
    // 射程距離
    public float rangeDistance = 4.0f;
    GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // プレイヤーの位置
        var playerPosition = player.transform.position;

        // みゃくみゃくの位置
        var myakuPosition = transform.position;

        // みゃくみゃくとプレイヤーがどれだけ離れているか
        //var offset = Mathf.Abs(playerPosition.z - myakuPosition.z);

        // みゃくみゃくとプレイヤーがどれだけ離れているかを計算
        var distance = Vector3.Distance(playerPosition, myakuPosition);

        // 距離をログに出力
        //Debug.Log($"Distance to player: {distance}");

        if (distance <= rangeDistance)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
