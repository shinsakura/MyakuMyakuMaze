using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyakuMyaku : MonoBehaviour
{
    // �˒�����
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
        // �v���C���[�̈ʒu
        var playerPosition = player.transform.position;

        // �݂Ⴍ�݂Ⴍ�̈ʒu
        var myakuPosition = transform.position;

        // �݂Ⴍ�݂Ⴍ�ƃv���C���[���ǂꂾ������Ă��邩
        //var offset = Mathf.Abs(playerPosition.z - myakuPosition.z);

        // �݂Ⴍ�݂Ⴍ�ƃv���C���[���ǂꂾ������Ă��邩���v�Z
        var distance = Vector3.Distance(playerPosition, myakuPosition);

        // ���������O�ɏo��
        //Debug.Log($"Distance to player: {distance}");

        if (distance <= rangeDistance)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
