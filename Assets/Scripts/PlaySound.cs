using UnityEngine;

public class PlaySound : MonoBehaviour
{
    // AudioSourceコンポーネントへの参照
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        // AudioSourceコンポーネントを取得
        audioSource = GetComponent<AudioSource>();


    }

    private void Update()
    {
        // 音声を再生
        PlayAudio();
    }

    // 音声を再生する関数
    void PlayAudio()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogError("AudioSourceコンポーネントが見つかりません！");
        }
    }
}