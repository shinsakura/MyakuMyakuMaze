using UnityEngine;

public class PlaySound : MonoBehaviour
{
    // AudioSource�R���|�[�l���g�ւ̎Q��
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        // AudioSource�R���|�[�l���g���擾
        audioSource = GetComponent<AudioSource>();


    }

    private void Update()
    {
        // �������Đ�
        PlayAudio();
    }

    // �������Đ�����֐�
    void PlayAudio()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogError("AudioSource�R���|�[�l���g��������܂���I");
        }
    }
}